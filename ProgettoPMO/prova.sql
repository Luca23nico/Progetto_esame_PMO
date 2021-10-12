-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Ott 12, 2021 alle 17:46
-- Versione del server: 10.4.14-MariaDB
-- Versione PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `prova`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `libro`
--

CREATE TABLE `libro` (
  `id` int(11) NOT NULL,
  `titolo` varchar(255) NOT NULL,
  `autore` varchar(255) NOT NULL,
  `genere` varchar(255) NOT NULL,
  `descrizione` mediumtext NOT NULL,
  `immagine` varchar(255) NOT NULL,
  `pdf` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `libro`
--

INSERT INTO `libro` (`id`, `titolo`, `autore`, `genere`, `descrizione`, `immagine`, `pdf`) VALUES
(1, 'Harry Potter e la Pietra Filosofale', 'J.K. Rowling', 'Fantasy', 'Harry Potter, giovane mago, rimasto orfano, viene adottato dagli zii che lo\r\ntrattano come uno schiavo. All’età di 11 anni riceve una lettera di iscrizione ad\r\nHogwads, una scuola di magia, cosi Harry decide di andare in quella scuola anche\r\nsenza il consenso degli zii. Appena giunto a scuola Harry, trova una pietra speciale\r\ndetta pietra filosofale, Harry si sente in dovere di proteggerla da Voldemort, un\r\nmago malvagio che utilizzerebbe la pietra per diventare invincibile', 'https://cultura.biografieonline.it/wp-content/uploads/2012/02/harry-potter-e-la-pietra-filosofale.jpg', ''),
(2, 'Harry Potter e la Camera dei segreti', 'J.K. Rowling', 'Fantasy', 'Il secondo anno ad Hogwarts si rivela denso di pericoli per Harry Potter e i suoi amici: un mostro misterioso si aggira per la scuola pietrificando i maghi mezzosangue figli di babbani, e tutti incolpano Harry.', 'https://images-na.ssl-images-amazon.com/images/I/91HfhLiOzyL.jpg', ''),
(3, 'Harry Potter e il Prigioniero di Azkaban', 'J.K. Rowling', 'Fantasy', 'Harry Potter sta frequentando il terzo anno a Hogwarts e questa volta deve difendersi da un pericoloso assassino, Sirius Black, scappato dalla sorvegliata prigione per maghi di Azkaban e legato alla famiglia del piccolo mago.', 'https://images-na.ssl-images-amazon.com/images/I/91AlxXCh2SL.jpg', ''),
(4, 'Harry Potter e il Calice di Fuoco', 'J.K. Rowling', 'Fantasy', 'Il quarto anno di Harry a Hogwarts è contrassegnato dal torneo di Tremaghi, nel quale i rappresentanti di ogni scuola di magia devono sfidarsi in alcune gare.', 'https://images-na.ssl-images-amazon.com/images/I/91sJm25RjuL.jpg', ''),
(5, 'Harry Potter e l\'Ordine della Fenice', 'J.K. Rowling', 'Fantasy ', 'Mentre si trova confinato contro la sua volontà a Privet Drive, Harry scopre che Albus Silente è a capo di una organizzazione segreta che ha il compito di contrapporsi e possibilmente sconfiggere Lord Voldemort.', 'https://images-na.ssl-images-amazon.com/images/I/91nsgvzjqJL.jpg', ''),
(6, 'Harry Potter e il Principe Mezzosangue', 'J.K. Rowling', 'Fantasy', 'Lord Voldemort stringe la sua presa sia sul mondo dei babbani che su quello dei maghi, Hogwarts non è più un rifugio sicuro. Harry sospetta che i pericoli possano nascondersi addirittura all\'interno del castello, ma Silente è deciso a prepararsi per lo scontro conclusivo che sembra prossimo.', 'https://images-na.ssl-images-amazon.com/images/I/A1wUgQbXfgL.jpg', ''),
(7, 'Harry Potter e i Doni della Morte', 'J.K. Rowling', 'Fantasy', 'Harry, insieme ai fidati Ron ed Hermione, decide di portare a termine il compito affidatogli da Silente e cercare tutti gli Horcrux per distruggerli.', 'https://images-na.ssl-images-amazon.com/images/I/81bJtADrYWL.jpg', ''),
(8, 'Il Codice da Vinci', 'Dan Brown', 'Romanzo', 'Un mistero che potrebbe scuotere le fondamenta del Cristianesimo si cela tra le opere di Leonardo. Il professore Langdon parte alla ricerca della scomoda verità assieme ad una criptologa francese.', 'https://images-na.ssl-images-amazon.com/images/I/719CeDchSsL.jpg', ''),
(9, 'La Divina Commedia: L\'Inferno ', 'Dante Alighieri', 'Poema', 'Dante racconta il suo viaggio nei regni ultraterreni del peccato (Inferno), dell\'espiazione (Purgatorio) e della salvezza (Paradiso). ... La commedia ha un inizio tragico e una conclusione positiva: dallo smarrimento di Dante nella selva oscura (peccato) fino alla salvezza,verso il viaggio che porta al Paradiso', 'https://images-na.ssl-images-amazon.com/images/I/81t-f4o1QML.jpg', ''),
(10, 'La Divina Commedia: Il Purgatorio', 'Dante Alighieri', 'Poema', 'Dante racconta il suo viaggio nei regni ultraterreni del peccato (Inferno), dell\'espiazione (Purgatorio) e della salvezza (Paradiso). ... La commedia ha un inizio tragico e una conclusione positiva: dallo smarrimento di Dante nella selva oscura (peccato) fino alla salvezza,verso il viaggio che porta al Paradiso', 'https://img.libraccio.it/images/9788844038106_0_500_0_75.jpg', ''),
(11, 'La Divina Commedia: Il Paradiso', 'Dante Alighieri', 'Poema', 'Dante racconta il suo viaggio nei regni ultraterreni del peccato (Inferno), dell\'espiazione (Purgatorio) e della salvezza (Paradiso). ... La commedia ha un inizio tragico e una conclusione positiva: dallo smarrimento di Dante nella selva oscura (peccato) fino alla salvezza,verso il viaggio che porta al Paradiso', 'https://www.itacalibri.it/System/148863/ns_paradiso-dante(1)(1).jpg', ''),
(12, 'IT', 'Stephen King', 'Horror', 'Un gruppo di adolescenti scopre l\'esistenza di un\'entità malvagia che si nutre delle paure degli esseri umani e che ha le sembianze di un pagliaccio di nome Pennywise. L\'essere, che dimora nelle profondità della rete fognaria, è solo uno dei volti della creatura millenaria nota come It, un mostro senza forma che si risveglia ciclicamente per mietere vittime tra i bambini della città. Per sconfiggerlo, i ragazzi devono restare uniti e mantenere vivo il sentimento di amicizia che li lega.', 'https://m.media-amazon.com/images/I/41lHSBlaSPL.jpg', ''),
(13, '22-11-1963', 'Stephen King', 'Fantascienza', 'L\'insegnante di liceo Jake Epping si ritrova a viaggiare nel tempo per cercare di impedire l\'assassinio di JFK, ma dovrà vedersela con Lee Harvey Oswald, un amore imprevisto e con il passato, che non vuole essere cambiato.', 'https://images-na.ssl-images-amazon.com/images/I/81-2xIrPiYL.jpg', ''),
(14, 'Shining', 'Stephen King', 'Horror', 'Jack Torrance, aspirante scrittore, accetta l\'incarico di guardiano invernale di un albergo in un luogo isolato sulle montagne del Colorado. Ma suo figlio Danny inizia a sperimentare delle visioni riguardo i terribili eventi accaduti nella struttura.', 'https://images-na.ssl-images-amazon.com/images/I/51jSPyJ8v2L._SX302_BO1,204,203,200_.jpg', ''),
(15, 'Harry Potter e la Maledizione dell\'Erede', 'J.K. Rowling', 'Fantasy', 'Diciannove anni dopo la morte di Lord Voldemort nella battaglia di Hogwarts, Harry Potter, divenuto famosissimo, è il capo dell\'Ufficio Applicazione della Legge sulla Magia e ha tre figli con Ginny Weasley: James Sirius, Albus Severus e Lily Luna. Hermione Granger, diventata Ministro della Magia, è sposata con Ron Weasley, che ha ereditato il negozio Tiri Vispi Weasley e ha due figli, Rose e Hugo, che hanno entrambi acquisito il doppio cognome Granger-Weasley.', 'https://images-na.ssl-images-amazon.com/images/I/813DJAlWx5L.jpg', ''),
(16, 'Il GGG: Grande Gigante Gentile', 'Roald Dahl', 'Romanzo', 'Una ragazzina di dieci anni, Sophie, viene rapita dal grande gigante gentile e portata nel suo mondo. I due amici devono escogitare un piano per liberarsi dei cattivi che vogliono attaccare gli umani.', 'https://www.spulcialibri.it/storage/app/uploads/public/3d6/a40/d27/thumb__420_0_0_0_auto.jpg', ''),
(17, 'La Fabbrica di Cioccolato', 'Roald Dahl', 'Fantasy', 'Cinque biglietti d\'oro sono nascosti in altrettante tavolette di cioccolato. I fortunati bambini che riescono a trovarli possono varcare i cancelli della Fabbrica di Cioccolato del signor Wonka ed entrare così in contatto con il suo magico mondo di dolci e bontà. Trai tanti bambini che sperano di avere una possibilità di vincere c\'è il piccolo Charlie.', 'https://img.illibraio.it/images/9788869186318_92_310_0_75.jpg', '');

-- --------------------------------------------------------

--
-- Struttura della tabella `prestiti`
--

CREATE TABLE `prestiti` (
  `id` int(11) NOT NULL,
  `idlibro` int(11) NOT NULL,
  `idutente` int(11) NOT NULL,
  `inizioprestito` date DEFAULT NULL,
  `fineprestito` date DEFAULT NULL,
  `restituito` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struttura della tabella `utente`
--

CREATE TABLE `utente` (
  `id` int(11) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `cognome` varchar(255) NOT NULL,
  `datanascita` date NOT NULL,
  `user` varchar(255) NOT NULL,
  `psw` varchar(255) NOT NULL,
  `immagine` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `libro`
--
ALTER TABLE `libro`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`);

--
-- Indici per le tabelle `prestiti`
--
ALTER TABLE `prestiti`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`),
  ADD KEY `idlibro` (`idlibro`),
  ADD KEY `idutente` (`idutente`);

--
-- Indici per le tabelle `utente`
--
ALTER TABLE `utente`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`);

--
-- AUTO_INCREMENT per le tabelle scaricate
--

--
-- AUTO_INCREMENT per la tabella `libro`
--
ALTER TABLE `libro`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT per la tabella `prestiti`
--
ALTER TABLE `prestiti`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=189;

--
-- AUTO_INCREMENT per la tabella `utente`
--
ALTER TABLE `utente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Limiti per le tabelle scaricate
--

--
-- Limiti per la tabella `prestiti`
--
ALTER TABLE `prestiti`
  ADD CONSTRAINT `prestiti_ibfk_1` FOREIGN KEY (`idlibro`) REFERENCES `libro` (`id`),
  ADD CONSTRAINT `prestiti_ibfk_2` FOREIGN KEY (`idutente`) REFERENCES `utente` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
