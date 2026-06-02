-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 02 juin 2026 à 23:38
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


CREATE USER IF NOT EXISTS 'userMediatek'@'localhost'
IDENTIFIED BY 'mdpMediatek86';

GRANT ALL PRIVILEGES ON mediatek86.* TO 'userMediatek'@'localhost';

FLUSH PRIVILEGES;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `datedebut` date NOT NULL,
  `idpersonnel` int NOT NULL,
  `idmotif` int NOT NULL,
  `datefin` date NOT NULL,
  PRIMARY KEY (`datedebut`,`idpersonnel`),
  KEY `idpersonnel` (`idpersonnel`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`datedebut`, `idpersonnel`, `idmotif`, `datefin`) VALUES
('2025-01-13', 2, 2, '2025-01-16'),
('2025-01-20', 3, 3, '2025-01-22'),
('2025-01-27', 4, 1, '2025-01-31'),
('2025-02-03', 5, 4, '2025-02-07'),
('2025-02-10', 6, 2, '2025-02-13'),
('2025-02-17', 7, 1, '2025-02-21'),
('2025-02-24', 8, 3, '2025-02-26'),
('2025-03-03', 9, 2, '2025-03-05'),
('2025-03-10', 10, 1, '2025-03-14'),
('2025-03-17', 1, 1, '2025-03-19'),
('2025-03-24', 2, 1, '2025-03-28'),
('2025-03-31', 3, 2, '2025-04-02'),
('2025-04-07', 4, 4, '2025-04-11'),
('2025-04-14', 5, 1, '2025-04-18'),
('2025-04-21', 6, 3, '2025-04-23'),
('2025-04-28', 7, 2, '2025-05-01'),
('2025-05-05', 8, 1, '2025-05-09'),
('2025-05-12', 9, 4, '2025-05-16'),
('2025-05-19', 10, 2, '2025-05-21'),
('2025-05-26', 1, 1, '2025-05-30'),
('2025-06-02', 2, 3, '2025-06-04'),
('2025-06-09', 3, 2, '2025-06-12'),
('2025-06-16', 4, 1, '2025-06-20'),
('2025-06-23', 5, 4, '2025-06-27'),
('2025-06-30', 6, 1, '2025-07-04'),
('2025-07-07', 7, 2, '2025-07-09'),
('2025-07-14', 8, 3, '2025-07-16'),
('2025-07-21', 9, 1, '2025-07-25'),
('2025-07-28', 10, 4, '2025-08-01'),
('2025-08-04', 1, 2, '2025-08-06'),
('2025-08-11', 2, 1, '2025-08-15'),
('2025-08-18', 3, 3, '2025-08-20'),
('2025-08-25', 4, 2, '2025-08-28'),
('2025-09-01', 5, 1, '2025-09-05'),
('2025-09-08', 6, 4, '2025-09-12'),
('2025-09-15', 7, 1, '2025-09-19'),
('2025-09-22', 8, 2, '2025-09-24'),
('2025-09-29', 9, 3, '2025-10-01'),
('2025-10-06', 10, 1, '2025-10-10'),
('2025-10-13', 1, 4, '2025-10-15'),
('2025-10-20', 2, 2, '2025-10-22'),
('2025-10-27', 3, 1, '2025-10-31'),
('2025-11-03', 4, 3, '2025-11-05'),
('2025-11-10', 5, 2, '2025-11-13'),
('2025-11-17', 6, 1, '2025-11-21'),
('2025-11-24', 7, 4, '2025-11-28'),
('2025-12-01', 8, 1, '2025-12-05'),
('2025-12-08', 9, 2, '2025-12-10'),
('2025-12-15', 10, 3, '2025-12-17');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Holman', 'Orlando', '0754162706', 'nunc.ullamcorper@icloud.edu', 1),
(2, 'Chandler', 'Brandon', '0723268914', 'et.eros@outlook.edu', 2),
(3, 'Leblanc', 'Evan', '0976345998', 'semper.rutrum.fusce@google.couk', 3),
(5, 'Mcintyre', 'Arseniofrfffff', '0611480748', 'in@aol.couk', 1),
(6, 'Maldonado', 'Ignacia', '0154011336', 'leo.in@icloud.com', 3),
(7, 'Peterson', 'Jordan', '0501173293', 'quam@yahoo.edu', 1),
(8, 'Burgess', 'Ross', '0626380120', 'tincidunt.nunc@hotmail.com', 2),
(9, 'Chaney', 'Denise', '0277678405', 'rutrum@aol.ca', 3),
(10, 'Burnett', 'Shaeleigh', '0708557451', 'non.lorem.vitae@protonmail.couk', 1),
(13, 'Tom', 'Pom', '454949894', 'fdsjfsdqfqd', 1),
(15, 'Tomsdsd', 'Pom', '454949894', 'fdsjfsdqfqd', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
