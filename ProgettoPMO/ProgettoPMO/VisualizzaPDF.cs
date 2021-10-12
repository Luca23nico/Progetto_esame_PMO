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
    public partial class VisualizzaPDF : Form
    {
        private string titolo;
        private MySqlConnection conn;
        private Database db;
        public VisualizzaPDF(string titolo, string utente)
        {
            InitializeComponent();
            this.titolo = titolo;
        }


        private void VisualizzaPDF_Load(object sender, EventArgs e)
        {
            db = Database.GetInstance();
            conn = db.GetDBConnection();
            string pdf = " ";
            string sql = "SELECT libro.pdf FROM libro where libro.titolo = @titolo";
            MySqlCommand cmd2 = new MySqlCommand(sql, conn);
            cmd2.Parameters.AddWithValue("@titolo", titolo);
            using (MySqlDataReader reader = cmd2.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        pdf = reader[0].ToString();
                    }
                }
                reader.Close();
            }
            conn.Close();
            WebBrowser web = new WebBrowser();
            axAcroPDF1.src = pdf;
            axAcroPDF1.Visible = true;
            axAcroPDF1.setLayoutMode("SinglePage");
            axAcroPDF1.setPageMode("none");
            axAcroPDF1.Show();
        }
    }
}
