using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPMO
{
    class Libro
    {
        private object id;
        private object titolo;
        private object autore;
        private object tipo;
        private object descrizione;
        private object copertina;

        public Libro(object titolo, object autore, object tipo)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.tipo = tipo;   
        }
        public Libro() { }

      
        public void Noleggia(MySql.Data.MySqlClient.MySqlConnection con, int id, string utente)
        {
            string query = "INSERT INTO prestiti(idlibro, idutente, inizioprestito, fineprestito) VALUES (@id,(SELECT id FROM utente WHERE utente.user = @user),@inizioprestito, @fineprestito)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@user", utente);
            cmd.Parameters.AddWithValue("@inizioprestito", DateTime.Today);
            cmd.Parameters.AddWithValue("@fineprestito", DateTime.Today.AddDays(30));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Restituisci(MySql.Data.MySqlClient.MySqlConnection con, int id, string utente)
        {
            string query = "UPDATE prestiti SET restituito = @restituito WHERE prestiti.idlibro = @id and prestiti.idutente = (SELECT id FROM utente WHERE utente.user = @user) and prestiti.restituito = ' '";
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@restituito", DateTime.Today);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@user", utente);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Info(ListView listView)
        {
            ListViewItem item = new ListViewItem(this.titolo.ToString());
            item.SubItems.Add(this.autore.ToString());
            item.SubItems.Add(this.tipo.ToString());
            listView.Items.Add(item);
        }
    }
}
