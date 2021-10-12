# Progetto_esame_PMO

Nome: Luca Nicoletti

Matricola: 299278

Titolo del progetto: Gestionale Prestito e restituzione di Libri

Specifica:
Si vuole creare un programma che gestisca il prestito e la restituzione di libri in una biblioteca.
 
Il programma prevede all'apertura un login dove verranno chiesti nome utente e password, previa registrazione.
 
Nella schermata principale troviamo:
- l'elenco dei libri disponibili dove si può:
           - visualizzare la scheda informativa di ogni titolo (copertina, titolo, autore, genere 
 	 e una breve descrizione);
           - cercare un determinato libro in base a titolo, autore o genere;
           - prendere in prestito oppure restituire uno o più titoli.
 
-l'Area Personale dove si potrà visualizzare:
           - la lista dei libri attualmente in prestito e il relativo file pdf;
           - lo storico di tutti i libri presi in prestito dall'utente.
 
-l'Area Profilo, dove l'utente potrà visualizzare i suoi dati ed eventualmente modificarli.
 
-l'Area "Scelti per te", in cui il programma elabora una lista di titoli in base ai prestiti precedenti.
 
Il tutto è gestito tramite la memorizzazione dei dati in un database Mysql.
