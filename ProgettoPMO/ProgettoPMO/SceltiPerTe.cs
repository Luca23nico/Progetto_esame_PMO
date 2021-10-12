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
    public partial class SceltiPerTe : Form
    {
        private string utente; // variabile che tiene memoria dell'utente loggato
        private MySqlConnection conn;
        private Database db;
        public SceltiPerTe(string utente)
        {
            InitializeComponent();
            this.utente = utente;
        }
        List<string> valori = new List<string>(); // lista contenente i valori da andare a sostiture ai segnaposti nelle query
        List<string> segnaposti = new List<string>(); // lista contente i segnaposti della query 
        
        string autore = ""; // autore più seguito
        string genere = ""; // genere più seguito

        // metodo di caricamento quando viene inizializzata la query
        private void SceltiPerTe_Load(object sender, EventArgs e)
        {
            var qu = new Query(); // creazione dell'istanza del querybuilder
            db = Database.GetInstance(); // creazione dell'istanza di connessione con il database 
            conn = db.GetDBConnection(); // acquisizione della connessione 

            // query per selezionare tutti gli autori seguiti dall'utente loggato
            string sql = "SELECT autore FROM libro INNER JOIN prestiti ON libro.id = prestiti.idlibro INNER JOIN utente ON utente.id = prestiti.idutente WHERE utente.user = @user";

            // query per selezionare tutti i generi seguiti dall'utente loggato
            string sql2 = "SELECT genere FROM libro INNER JOIN prestiti ON libro.id = prestiti.idlibro INNER JOIN utente ON utente.id = prestiti.idutente WHERE utente.user = @user";
            var select = new Select(); // creazione di un istanza select contenente i metodi da utilizzare per le operazioni 
            autore = select.Max(sql, conn, this.utente); // restituzione dell'autore più seguito dall'utente loggato
            genere = select.Max(sql2, conn,this.utente); // restituzione del genere più seguito dall'utente loggato

            valori.Add(autore);
            valori.Add(genere);
            string sql3 = qu.Table("libro").Select("titolo","autore","genere").Where("autore", "@autore").OrWhere("genere","@genere").Sql;
            segnaposti.Add("@autore");
            segnaposti.Add("@genere");
            select.Esegui(sql3, conn, listView1, valori, segnaposti); // esecuzione della query 
            segnaposti.Clear();
            valori.Clear();
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e) //
        {
            String titolo = listView1.SelectedItems[0].Text;
            Scheda f4 = new Scheda(titolo, this.utente);
            f4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var qu = new Query(); // creazione dell'istanza del querybuilder

            db = Database.GetInstance(); // creazione dell'istanza di connessione con il database 

            conn = db.GetDBConnection(); // acquisizione della connessione 

            var select = new Select(); // creazione dell'istanza della classe che fa le operazioni

            string sql = qu.Table("utente").Select("immagine").Where("user", "@val").Sql;  // query per acquisire immagine 

            string immagine = select.GetValore(sql, conn, this.utente); //acquisizione dell'immagine

            Lista lista = new Lista(this.utente, immagine);
            lista.Show();
            this.Close();
        }
    }
}