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
    public partial class Profilo : Form
    {
        private string utente;
        private MySqlConnection conn;
        private Database db;
        private int id;
        public Profilo(string utente)
        {
            InitializeComponent();
            this.utente = utente;
        }
        Query qu = new Query();
        Select select = new Select();
        private void Profilo_Load(object sender, EventArgs e)
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();
      
            string sql = qu.Table("utente").Select("id","nome", "cognome", "datanascita", "user", "immagine").Where("user","@var").Sql; // carica i dati dell'utente
            select.Informazioni(sql, conn, this.utente, textBox1, textBox2, textBox4, textBox3, pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e) // accesso all'area di modifica dell'utente
        {
            ModificaUtente modificaUtente = new ModificaUtente(utente);
            modificaUtente.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista(textBox3.Text, pictureBox2.ImageLocation);
            lista.Show();
            this.Close();
        }
    }
}
