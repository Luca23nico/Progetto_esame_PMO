using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgettoPMO
{
    public partial class Login : Form
    {

        private MySqlConnection conn; // connessione con database
        private Database db; // istanza del database

        public Login()
        {
            InitializeComponent();
        }
        
        Query qu = new Query(); // istanza query builder
        Select select = new Select(); // istanza classe select, classe che si occupa delle operazioni

        List<string> segnaposti = new List<string>(); // lista contenente i segnaposti della query
        List<string> valori = new List<string>(); // lista contenente i valori da sostituire ai segnaposti della query
        private void btn_login_Click(object sender, EventArgs e)
        {
           
            db = Database.GetInstance(); // acquisizione dell'istanza del db
            conn = db.GetDBConnection(); // acquisizione della connessione con il db
          
            // costruzione della query
            string sql = qu.Table("utente").Select("user","immagine").Where("utente.user", "@user").AndWhere("utente.psw", "@psw").Sql;

            // popolo la lista dei segnaposti
            segnaposti.Add("@user");
            segnaposti.Add("@psw");

            // popolo la lista dei valori
            valori.Add(text_user.Text);
            valori.Add(text_psw.Text);

            select.Login(sql, conn, valori, segnaposti); // richiamo al metodo per eseguire il login

            text_user.Text = "";
            text_psw.Text = "";

            segnaposti.Clear();
            valori.Clear();
        }

        private void lblRegistrazione_Click(object sender, EventArgs e)
        {
            Form f2 = new Registrazione();
            f2.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // serve per rendere visibile o meno la password
        {
            if (checkBox1.Checked) 
            {
                text_psw.PasswordChar = '\0';
            }
            else
            {
                text_psw.PasswordChar = '•';
            }
        }
    }
}
