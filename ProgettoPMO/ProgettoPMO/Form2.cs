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
    public partial class Registrazione : Form
    {
        private MySqlConnection conn;
        private Database db;
        public Registrazione()
        {
            InitializeComponent();
        }
        List<string> valori = new List<string>();  // lista contenente i segnaposti della query
        List<string> segnaposti = new List<string>(); // lista contenente i valori da sostituire ai segnaposti della query

        Query qu = new Query(); 
        Select select = new Select();
        private void btn_immagine_Click(object sender, EventArgs e) // carica l'immagine di profilo dell'utente
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                textbox_immagine.Text = open.FileName;

            }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();

            string sql = qu.Table("utente").Where("user", "@user").Sql;
            segnaposti.Add("@user");
            valori.Add(text_user.Text);

            // Verifica che i dati inseriti siano corretti
            if (text_nome.Text == "" || text_cognome.Text == "" || text_psw.Text == "" || textBox_rptpsw.Text == "" || textbox_immagine.Text == "")
            {
                MessageBox.Show("Uno o Più Campi Non Sono Stati Utilizzati", "Registrazione Fallita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (select.Verifica(sql, conn, segnaposti, valori))
                {
                    MessageBox.Show("Username Già Utilizzato", "Registrazione Fallita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_user.Text = "";
                    segnaposti.Clear();
                    valori.Clear();
                }
                else
                {
                    segnaposti.Clear();
                    valori.Clear();
                    if (text_psw.Text == textBox_rptpsw.Text)
                    {
                        string sql2 = "INSERT INTO `utente`(`id`, `nome`, `cognome`, `datanascita`, `user`, `psw`, `immagine`) VALUES(NULL, @nome, @cognome, @datanascita, @user, @psw, @immagine)";
                        segnaposti.Add("@nome");
                        segnaposti.Add("@cognome");
                        segnaposti.Add("@datanascita");
                        segnaposti.Add("@user");
                        segnaposti.Add("@psw");
                        segnaposti.Add("@immagine");
                        valori.Add(text_nome.Text);
                        valori.Add(text_cognome.Text);
                        valori.Add(dateTimePicker1.Text);
                        valori.Add(text_user.Text);
                        valori.Add(text_psw.Text);
                        valori.Add(textbox_immagine.Text);
                        select.Insert(sql2, conn, segnaposti, valori);
                       
                        MessageBox.Show("Account creato con successo", "Registrazione avvenuta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        segnaposti.Clear();
                        valori.Clear();
                        Login login = new Login();
                        login.Show();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Le Password Non Corrispondono, Riprovare!!", "Registrazione Fallita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        text_psw.Text = "";
                        textBox_rptpsw.Text = "";
                    }
                }
            }
            segnaposti.Clear();
            valori.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                text_psw.PasswordChar = '\0';
                textBox_rptpsw.PasswordChar = '\0';
            }
            else
            {
                text_psw.PasswordChar = '•';
                textBox_rptpsw.PasswordChar = '•';
            }
        }

        private void btn_indietro_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
