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
    public partial class ModificaUtente : Form
    {
        private string utente;
        private Database db;
        private MySqlConnection conn;
        public ModificaUtente(string utente)
        {
            InitializeComponent();
            this.utente = utente;
        }
        int id;
        List<string> valori = new List<string>();
        List<string> segnaposti = new List<string>();
        Query qu = new Query();
        Select select = new Select();
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificaUtente_Load(object sender, EventArgs e)
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();
           
            // carica i vecchi dati dell'utente
            string sql = qu.Table("utente").Select("id", "nome", "cognome", "user", "psw", "immagine").Where("user", "@var").Sql; 
            id = select.Informazioni(sql, conn, this.utente, textbox_nome, textBox_cognome, textBox_user, textBox_passwordv, pictureBox1);
            text_immagine.Text = pictureBox1.ImageLocation;
        }

        private void button2_Click(object sender, EventArgs e) // carica l'immagine di profilo dell'utente
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
                text_immagine.Text = open.FileName;
                //pictureBox1.Image.= open.FileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // permette di visualizzare o meno le password
        {
            if (checkBox1.Checked)
            {
                textBox_passwordv.PasswordChar = '\0';
                textbox_pswn.PasswordChar = '\0';
                textBox_rptPass.PasswordChar = '\0';
            }
            else
            {
                textBox_passwordv.PasswordChar = '•';
                textbox_pswn.PasswordChar = '•';
                textBox_rptPass.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            db = Database.GetInstance();
            conn = db.GetDBConnection();
           
            string sql = "UPDATE utente SET user = @user, psw = @password, immagine = @immagine WHERE id = @id";
            string sql2 = qu.Table("utente").Where("user", "@user").Sql;
            segnaposti.Add("@user");
            valori.Add(textBox_usern.Text);
            // varifica che i nuovi dati inseriti siano corretti
            if (textBox_usern.Text != "" && textBox_rptPass.Text != "")
            {
                if(textbox_pswn.Text != textBox_rptPass.Text)
                {
                    MessageBox.Show("Password non corrispondono", "Modifica fallita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    segnaposti.Clear();
                    valori.Clear();
                    textbox_pswn.Text = "";
                    textBox_rptPass.Text = "";
                }
                else
                {
                    if(select.Verifica(sql2,conn,segnaposti,valori))
                    {
                        MessageBox.Show("Username già utilizzato", "Modifica Fallita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        segnaposti.Clear();
                        valori.Clear();
                        textBox_usern.Text = ""; 
                    }
                    else
                    {
                        segnaposti.Clear();
                        valori.Clear();
                        segnaposti.Add("@user");
                        segnaposti.Add("@password");
                        segnaposti.Add("@immagine");
                        segnaposti.Add("@id");
                        valori.Add(textBox_usern.Text);
                        valori.Add(textbox_pswn.Text);
                        valori.Add(text_immagine.Text);
                        valori.Add(id.ToString());
                        select.Insert(sql, conn, segnaposti, valori);
                        utente = textBox_usern.Text;
                        MessageBox.Show("Modifica avvenuta con successo", "Modifica Effettuata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (textBox_usern.Text != "")
                {
                    if (select.Verifica(sql2, conn, segnaposti, valori))
                    {
                        MessageBox.Show("Username già utilizzato", "Modifica Fallita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        segnaposti.Clear();
                        valori.Clear();
                    }
                    else
                    {
                        segnaposti.Clear();
                        valori.Clear();
                        segnaposti.Add("@user");
                        segnaposti.Add("@password");
                        segnaposti.Add("@immagine");
                        segnaposti.Add("@id");
                        valori.Add(textBox_usern.Text);
                        valori.Add(textBox_passwordv.Text);
                        valori.Add(text_immagine.Text);
                        valori.Add(id.ToString());
                        select.Insert(sql, conn, segnaposti, valori);
                        utente = textBox_usern.Text;
                        MessageBox.Show("Modifica avvenuta con successo", "Modifica Effettuata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if(textbox_pswn.Text != "")
                    {
                        if (textbox_pswn.Text == textBox_rptPass.Text)
                        {
                            segnaposti.Clear();
                            valori.Clear();
                            segnaposti.Add("@user");
                            segnaposti.Add("@password");
                            segnaposti.Add("@immagine");
                            segnaposti.Add("@id");
                            valori.Add(textBox_user.Text);
                            valori.Add(textbox_pswn.Text);
                            valori.Add(text_immagine.Text);
                            valori.Add(id.ToString());
                            select.Insert(sql, conn, segnaposti, valori);
                            utente = textBox_user.Text;
                            MessageBox.Show("Password cambiata", "Modifica Effettuata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Password non corrispondono", "Modifica fallita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            segnaposti.Clear();
                            valori.Clear();
                        }
                    }
                    else
                    {
                        segnaposti.Clear();
                        valori.Clear();
                        segnaposti.Add("@user");
                        segnaposti.Add("@password");
                        segnaposti.Add("@immagine");
                        segnaposti.Add("@id");
                        valori.Add(textBox_user.Text);
                        valori.Add(textBox_passwordv.Text);
                        valori.Add(text_immagine.Text);
                        valori.Add(id.ToString());
                        select.Insert(sql, conn, segnaposti, valori);
                        utente = textBox_user.Text;
                    }
                }
                segnaposti.Clear();
                valori.Clear();
                Profilo profilo = new Profilo(utente);
                profilo.Show();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Profilo profilo = new Profilo(textBox_user.Text);
            profilo.Show();
            this.Close();
        }
    }
}

                