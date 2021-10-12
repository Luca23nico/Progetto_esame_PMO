using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPMO
{
    class Select //classe che esegue le query
    {

        private Database db = Database.GetInstance();

        public Select() { }

        public void Login(string sql, MySqlConnection con, List<string> valori, List<string> segnaposti) // metodo che esegue il login 
        {
            con = db.GetDBConnection(); // verifica della connessione con il db, se è chiusa viene aperta

            int k = 0; //contatore

            MySqlCommand query = new MySqlCommand(sql, con); // inizializzazione della query di ricerca
            while (k < valori.Count) // ciclo che inserisce i valori nei segnaposti
            {
                query.Parameters.AddWithValue(segnaposti[k], valori[k]); // sostituzione del segnaposto con il valore
                k++;
            }
            using (MySqlDataReader reader = query.ExecuteReader())
            {
                if (reader.HasRows) // se sono presenti risultati allora estite il profilo 
                {
                     reader.Read(); // legge i dati 
                     
                     // acquisizione dei dati 
                     string immagine = reader[1].ToString();
                     string utente = reader[0].ToString();
                     con.Close();
                     Lista f3 = new Lista(utente, immagine);
                     f3.Show();
                }
                else
                {
                    // se non esiste il profilo viene generato un errore
                    MessageBox.Show("Username o Password Errati","Login Fallito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close(); // chiusura dell'oggetto che legge i dati
            }
            con.Close(); // chiusura della connessione 
        }

        public void Insert(string sql, MySqlConnection con, List<string> segnaposti, List<string> valori) // funzione che inserisce o modifica l'utente
        {
            con = db.GetDBConnection(); // verifica della connessione 
           
            int i = 0; // contatore 

            MySqlCommand query = new MySqlCommand(sql, con); // inizializzazione della query di ricerca
            while(i < segnaposti.Count) // ciclo che inserisce i valori nei segnaposti 
            {
                query.Parameters.AddWithValue(segnaposti[i], valori[i]); // sostituzione del segnaposto con il valore
                i++;
            }
            query.ExecuteNonQuery(); // esecuzione della query di inserimento 
           
            con.Close(); // chiusura della connessione 
        }

        public void Esegui(string sql, MySqlConnection con, ListView listView, List<string> valori, List<string> segnaposti) // metodo che carica i libri
        {
            con = db.GetDBConnection(); // verfica della connessione
            int j = 0; // contatore 

            List<Libro> libri = new List<Libro>(); // lista che contiene i libri
            MySqlCommand query = new MySqlCommand(sql, con); // inizializzazione della query di ricerca
            if (segnaposti.Count != 0) // se non ci sono segnaposti vengono caricati tutti i libri
            {
                while (j < segnaposti.Count) // ciclo che sostituisce i valori nei segnaposti
                {
                    query.Parameters.AddWithValue(segnaposti[j], valori[j]); // sostituzione del segnaposto con il valore
                    j++;
                }
            }
            libri.RemoveRange(0, libri.Count); //viene svuotato la lista
            listView.Items.Clear(); // viene svuotata la listView poter visualizzare solo i libri voluti

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read()) // ciclo che acquisisce i dati dei libri 
                    {
                        libri.Add(new Libro(reader[0], reader[1], reader[2])); // creazione del libro 
                    }
                    for (int i = 0; i < libri.Count; i++)
                    {
                        libri[i].Info(listView); // metodo che inserisce i libri nel listview
                    }
                }
                reader.Close();
            }
            con.Close(); // chiusura della connessione 
        }

        // metodo che mostra i dati dei libri o dell'utente
        public int Informazioni(string sql, MySqlConnection con, string segnaposto, TextBox valore1, TextBox valore2, TextBox valore3, TextBox valore4, PictureBox immagine)
        {
            con = db.GetDBConnection(); // verifica della connessione 

            int? id = null;
            MySqlCommand query = new MySqlCommand(sql, con); // inizializzazione della query di ricerca

            query.Parameters.AddWithValue("@var", segnaposto); // sostituzione del segnaposto con il valore

            using (MySqlDataReader reader = query.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read()) // ciclo che acquisisce i dati 
                    {
                        // acquisizione dei dati 

                        id = int.Parse(reader[0].ToString());
                        valore1.Text = reader[1].ToString(); 
                        valore2.Text = reader[2].ToString(); 
                        valore3.Text = reader[3].ToString(); 
                        valore4.Text = reader[4].ToString(); 
                        immagine.Load(reader[5].ToString()); 
                    }
                }
                else
                {
                    //messaggio di errore nel caso in cui non vengano trovati elementi
                    MessageBox.Show("Non è stato trovato alcun elemento");
                }
                reader.Close();
            }
            con.Close(); // chiusura della connessione
            return (int)id;
        }

        // metodo per verifica quale sia l'autore e il genere più seguito dall'autente
        public string Max(string sql, MySqlConnection con, string utente) 
        {
            con = db.GetDBConnection(); // verifica della connessione 

            string dato = "";

            List<string> dati = new List<string>(); // lista contenente tutti gli autori generi presi in prestito dall'utente

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@user", utente); // sostituzione del segnaposto in valore
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows) 
                {
                    while (reader.Read())
                    {
                        dati.Add(reader[0].ToString());

                    }
                }
                dati.Sort(); // ordinamento della lista 
            }
            con.Close(); // chiusura della connessione 

            //inizio dell algoritmo che verifica quale è l'autore o il genere più seguito 

            int max = 0; // massimo assuluto
            int tmp = 0; // variabile di aiuto 
            string nometmp = ""; // autore temporaneo
            for (int i = 0; i < dati.Count; i++)
            {
                for (int j = 0; j < dati.Count; j++)
                {
                    if (dati[i] == dati[j])
                    {
                        nometmp = dati[j];
                        tmp++;
                    }
                }
                if (tmp >= max)
                {
                    max = tmp;
                    dato = nometmp;
                }
                tmp = 0;
            }
            return dato;
        }

        public bool Verifica(string sql, MySqlConnection con, List<string> segnaposti, List<string> valori) // verifica se il nome utente è stato utilizzato già da un altro utente  
        {
            con = db.GetDBConnection(); // verifica della connessione
            int j = 0; // contatore
            bool flag = false; // variabile booleana che mi indica se è vera indica che il nome utente è già stato utilizzato 
            
          
            MySqlCommand query = new MySqlCommand(sql, con); // inizializzazione della query 

            while (j < segnaposti.Count)
            {
                query.Parameters.AddWithValue(segnaposti[j], valori[j]);
                j++;
            }
            using (MySqlDataReader reader = query.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    flag = true;
                }
            }
            con.Close();
            return flag;
        }

        // metodo che permette di acquisire un parametro di un libro oppure di un utente
        public string GetValore(string sql, MySqlConnection con,string parametro)
        {
            string valore = "";
            con = db.GetDBConnection();
            MySqlCommand query = new MySqlCommand(sql, con);
            query.Parameters.AddWithValue("@val",parametro);
            using (MySqlDataReader reader = query.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        valore = reader[0].ToString();
                    }
                }
            }
            con.Close();
            return valore;
        }
        
        // metodo che restituisce un libro in modo automatico se la data attuale è maggiore o uguale alla data di fine prestito
        public void Restituzioneforzata(string sql, MySqlConnection con, string parametro)
        {
            Libro libro = new Libro();
            List<int> idlibri = new List<int>(); // lista che contiene tutti gli id dei libri che devono essere restituiti in modo forzato
            con = db.GetDBConnection();
            MySqlCommand query = new MySqlCommand(sql, con);
            query.Parameters.AddWithValue("@val", parametro);
            query.Parameters.AddWithValue("@data", DateTime.Today);
            using (MySqlDataReader reader = query.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idlibri.Add(int.Parse(reader[0].ToString())); // id aggiunto alla lista
                    }
                }
            }
            if(idlibri.Count > 0)
            {
                MessageBox.Show("Uno o Più libri sono stati restituiti in modo forzato, perchè è teminato il tempo di prestito", "Restituzione forzata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                for (int i = 0; i < idlibri.Count; i++)
                {
                    libro.Restituisci(con, idlibri[i], parametro); // richiamo al metodo della classe libro per restituire il libro
                }
                idlibri.Clear(); // pulizia della lista 
            }
            con.Close();
        }
    }
}
