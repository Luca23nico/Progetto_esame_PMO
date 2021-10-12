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
    public partial class Scheda : Form
    {
        private string utente;
        private int idlibro;
        private string titolo;
        private string immagine;
        private MySqlConnection conn;
        private Database db;
        public Scheda(string titolo, string utente)
        {
            InitializeComponent();
            this.titolo = titolo;
            this.utente = utente;
        }
        List<string> valori = new List<string>();
        List<string> segnaposti = new List<string>();
       
        Query qu = new Query();
        Select select = new Select();
        private void Scheda_Load(object sender, EventArgs e)
        {
            
            db = Database.GetInstance();
            conn = db.GetDBConnection();
           
            string sql = qu.Table("libro").Where("titolo", "@var").Sql;
            this.idlibro = select.Informazioni(sql, conn, this.titolo, textBox_titolo, textBox_autore, textBox_genere, textBoxdescrizione, pictureBox1);

            string sql2 = "SELECT prestiti.inizioprestito From prestiti WHERE prestiti.idlibro = @idlibro AND prestiti.idutente = (SELECT id from utente WHERE utente.user = @user)  AND prestiti.restituito = ' '";
            segnaposti.Add("@idlibro");
            segnaposti.Add("@user");
            valori.Add(this.idlibro.ToString());
            valori.Add(this.utente);

            if (select.Verifica(sql2, conn, segnaposti, valori)) // verifica se l'utente ha già in prestito il libro in questione
            {   
                btn_prestito.Text = "Restituisci";
            }
            else
            {
                btn_prestito.Text = "Prendi in Prestito";
            }
        }

        private void btn_prestito_Click(object sender, EventArgs e) // in base alla verifica precendente, l'utente può prendere in prestito o restituire il libro
        {
            conn = db.GetDBConnection();
            Libro libro1 = new Libro();
            if (btn_prestito.Text == "Prendi in Prestito")
            {
                libro1.Noleggia(conn, idlibro, this.utente);
                MessageBox.Show("Grazie per Aver preso in prestito il libro");
                btn_prestito.Text = "Restituisci";
            }
            else
            {
                libro1.Restituisci(conn, idlibro, this.utente);
                MessageBox.Show("Grazie per Aver riportato il libro");
                btn_prestito.Text = "Prendi in Prestito";
            }
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();
            string sql = qu.Table("utente").Select("immagine").Where("user", "@val").Sql;
            string immagineutente = select.GetValore(sql, conn, this.utente);
            Lista lista = new Lista(this.utente, immagineutente);
            lista.Show();
            this.Close();
        }
    }
}
