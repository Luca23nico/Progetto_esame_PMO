using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPMO
{
    public partial class AreaPersonale : Form
    {
        private string utente;
        //private int id;
        private MySqlConnection conn;
        private Database db;
        public AreaPersonale(string utente)
        {
            InitializeComponent();
            this.utente = utente;
        }

        List<string> valori = new List<string>();
        List<string> segnaposti = new List<string>();
        Query qu = new Query();
        Select select = new Select();
        private void AreaPersonale_Load(object sender, EventArgs e)
        {
            
            db = Database.GetInstance();
            conn = db.GetDBConnection();
            string sql = "SELECT libro.titolo, prestiti.inizioprestito, prestiti.fineprestito FROM libro INNER JOIN prestiti ON libro.id = prestiti.idlibro INNER JOIN utente ON utente.id = prestiti.idutente WHERE utente.user = @user AND prestiti.restituito = ''";
            valori.Add(this.utente);
            segnaposti.Add("@user");
            select.Esegui(sql, conn, listView1, valori, segnaposti);
        }

        private void btn_storico_Click(object sender, EventArgs e)
        {
            Storico storico = new Storico(this.utente);
            storico.Show();
            this.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String titolo = listView1.SelectedItems[0].Text;
            VisualizzaPDF visualizzaPDF = new VisualizzaPDF(titolo, this.utente);
            visualizzaPDF.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();
            string sql = qu.Table("utente").Select("immagine").Where("user", "@val").Sql;
            string immagine = select.GetValore(sql, conn, this.utente);
            Lista lista = new Lista(this.utente, immagine);
            lista.Show();
            this.Close();
        }
    }
}
