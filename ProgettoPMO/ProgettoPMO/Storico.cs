using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPMO
{
    public partial class Storico : Form
    {
        private string utente;
        private MySqlConnection conn;
        private Database db;
        public Storico(string utente)
        {
            InitializeComponent();
            this.utente = utente;
        }

        List<string> valori = new List<string>();
        List<string> segnaposti = new List<string>();
        Query qu = new Query();
        Select select = new Select();

        private void Storico_Load(object sender, EventArgs e)
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();
            string sql = "SELECT libro.titolo, prestiti.inizioprestito, prestiti.restituito FROM libro INNER JOIN prestiti ON libro.id = prestiti.idlibro INNER JOIN utente ON utente.id = prestiti.idutente WHERE utente.user =@user AND prestiti.restituito != ' '";
            valori.Add(this.utente);
            segnaposti.Add("@user");
            select.Esegui(sql, conn, listView1, valori, segnaposti);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AreaPersonale f3 = new AreaPersonale(utente);
            f3.Show();
            this.Close();
        }
    }
}
