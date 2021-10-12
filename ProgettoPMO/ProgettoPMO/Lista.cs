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
    public partial class Lista : Form
    {
        private string utente;
        private string immagine;
        private MySqlConnection conn;
        private Database db;
       
        public Lista(string utente,string immagine)
        {
            InitializeComponent();
            pictureBox1.Load(immagine);
            this.utente = utente;
            this.immagine = immagine;
            label2.Text = utente;
        }
      
        List<string> valori = new List<string>();
        List<string> segnaposti = new List<string>();

        Query qu = new Query();
        Select select = new Select();

        private void Lista_Load(object sender, EventArgs e)
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();
            string sql2 = "SELECT libro.id FROM libro INNER JOIN prestiti ON libro.id = prestiti.idlibro INNER JOIN utente ON utente.id = prestiti.idutente WHERE utente.user = @val AND Date(prestiti.fineprestito) <= @data And prestiti.restituito = 'NULL'";
            select.Restituzioneforzata(sql2, conn, utente);
            string sql = qu.Table("libro").Select("titolo","autore","genere").Sql;
            select.Esegui(sql, conn, listView1, valori, segnaposti);
            segnaposti.Clear();
            valori.Clear();
        }
      
        private void listView1_MouseClick(object sender, MouseEventArgs e) // permette il di visualizzare la scheda completa del libro
        {
            String titolo = listView1.SelectedItems[0].Text;
            Scheda f4 = new Scheda(titolo, this.utente);
            f4.Show();
            this.Close();

        }

        private void btn_ricerca_Click(object sender, EventArgs e) // permette la ricerca di un determinato libro
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();
            string sql = qu.Table("libro").Select("titolo","autore","genere").Where("titolo", "@var").OrWhere("autore", "@var").OrWhere("genere","@var").Sql;
            valori.Add(textbox_ricerca.Text);
            segnaposti.Add("@var");
            select.Esegui(sql, conn, listView1, valori, segnaposti);
            segnaposti.Clear();
            valori.Clear();
        }

        private void textbox_ricerca_TextChanged(object sender, EventArgs e) 
        { 
            if(textbox_ricerca.Text == "") // se la casella di ricerca è vuota, mostra tutti i libri disponibili
            {
                Lista_Load(sender, e);
            }
        }

        private void btn_areapersonale_Click(object sender, EventArgs e) // accesso all'area personale
        {
            
            AreaPersonale f3 = new AreaPersonale(this.utente);
            f3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // accesso ai dati del profilo 
        {
            Profilo f6 = new Profilo(this.utente);
            f6.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // accesso alla sezione scelti per te
        {
            SceltiPerTe f7 = new SceltiPerTe(this.utente);
            f7.Show();
            this.Close();
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
