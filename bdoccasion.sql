DROP DATABASE IF EXISTS bdoccasion;
CREATE DATABASE IF NOT EXISTS bdoccasion;

USE bdoccasion;

-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Jeu 14 Novembre 2019 à 09:28
-- Version du serveur :  5.7.11
-- Version de PHP :  7.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdoccasion`
--

-- --------------------------------------------------------

--
-- Structure de la table `cartegrise`
--

CREATE TABLE `cartegrise` (
  `idProp` int(3) NOT NULL,
  `immat` varchar(10) NOT NULL,
  `datecarte` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `cartegrise`
--

INSERT INTO `cartegrise` (`idProp`, `immat`, `datecarte`) VALUES
(1, 'BB-222-DE', '2019-01-30 23:00:00'),
(1, 'BR-363-SJ', '2015-10-02 22:00:00'),
(1, 'SR-163-RJ', '2017-08-31 22:00:00'),
(2, 'TB-652-OP', '2019-04-07 22:00:00'),
(3, 'SE-987-DD', '2017-04-30 22:00:00'),
(4, 'AQ-748-UK', '2018-12-31 23:00:00'),
(4, 'CF-699-ZE', '2017-12-31 23:00:00'),
(4, 'RT-578-CD', '2016-06-20 22:00:00'),
(5, 'EY-745-NM', '2018-12-14 23:00:00'),
(5, 'TT-123-PM', '2015-09-21 22:00:00'),
(6, 'AB-487-RE', '2018-10-24 22:00:00'),
(7, 'CV-789-XS', '2019-04-17 22:00:00'),
(8, 'FR-657-TX', '2019-04-09 22:00:00'),
(8, 'UI-325-FD', '2019-03-12 23:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `concessionnaire`
--

CREATE TABLE `concessionnaire` (
  `idConces` int(2) NOT NULL,
  `nom` varchar(15) NOT NULL,
  `prenom` varchar(15) NOT NULL,
  `adresse` varchar(50) NOT NULL,
  `codePostal` varchar(5) NOT NULL,
  `ville` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `concessionnaire`
--

INSERT INTO `concessionnaire` (`idConces`, `nom`, `prenom`, `adresse`, `codePostal`, `ville`) VALUES
(2, 'Fuller', 'Philippe', '254 avenue Berthelot', '63000', 'CLERMONT-FERRAND'),
(6, 'Bucyama', 'Michel', '15 rue des pinsons', '63200', 'RIOM'),
(7, 'King', 'Louis', '57 rue de la gare', '63500', 'ISSOIRE');

-- --------------------------------------------------------

--
-- Structure de la table `modele`
--

CREATE TABLE `modele` (
  `idModele` int(3) NOT NULL,
  `libModele` varchar(30) DEFAULT NULL,
  `marque` varchar(30) DEFAULT NULL,
  `carburant` enum('essence','diesel','gpl','électrique') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `modele`
--

INSERT INTO `modele` (`idModele`, `libModele`, `marque`, `carburant`) VALUES
(1, '207', 'Peugeot', 'essence'),
(2, '207', 'Peugeot', 'diesel'),
(3, '308', 'Peugeot', 'essence'),
(4, '308', 'Peugeot', 'diesel'),
(5, 'C2', 'Citroën', 'essence'),
(6, 'C2', 'Citroën', 'diesel'),
(7, 'C3 Picasso', 'Citroën', 'diesel'),
(8, 'A3', 'Audi', 'diesel'),
(9, 'A4', 'Audi', 'diesel');

-- --------------------------------------------------------

--
-- Structure de la table `proprietaire`
--

CREATE TABLE `proprietaire` (
  `idProp` int(3) NOT NULL,
  `nom` varchar(20) DEFAULT NULL,
  `prenom` varchar(20) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `codepostal` varchar(5) DEFAULT NULL,
  `ville` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `proprietaire`
--

INSERT INTO `proprietaire` (`idProp`, `nom`, `prenom`, `adresse`, `codepostal`, `ville`) VALUES
(1, 'DURAND', 'Yves', '40 rue du Breuil', '63118', 'CEBAZAT'),
(2, 'DUPUY', 'Charles', '5 place de Jaude', '63000', 'CLERMONT'),
(3, 'DURAND', 'Bernard', '130 avenue Berthelot', '66500', 'ISSOIRE'),
(4, 'MERLE', 'Caroline', '85 rue du temple', '63000', 'CLERMONT'),
(5, 'GARDY', 'Sylvie', '10 rue du port', '63000', 'CLERMONT'),
(6, 'JOBALET', 'Pascal', '54 avenue de la liberté', '63500', 'ISSOIRE'),
(7, 'VAISSEL', 'Stéphane', '18 place de Jaude', '63000', 'CLERMONT'),
(8, 'VAITOLET', 'Sabine', '30 impasse du fort', '63200', 'RIOM'),
(9, 'VAITOLET', 'Jean', '30 impasse du fort', '63200', 'RIOM'),
(10, 'VAZEL', 'Pascal', '3 rue Zola', '63000', 'CLERMONT');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `identifiant` varchar(30) NOT NULL,
  `motdepasse` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `utilisateur`
--

INSERT INTO `utilisateur` (`identifiant`, `motdepasse`) VALUES
('a', 'a'),
('aa', 'aa'),
('aaa', 'aaa');

-- --------------------------------------------------------

--
-- Structure de la table `voiture`
--

CREATE TABLE `voiture` (
  `immat` varchar(10) NOT NULL,
  `idModele` int(3) DEFAULT NULL,
  `nbPlaces` enum('2','4','5','7') DEFAULT NULL,
  `datePremImmat` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `voiture`
--

INSERT INTO `voiture` (`immat`, `idModele`, `nbPlaces`, `datePremImmat`) VALUES
('AB-487-RE', 7, '7', '2018-04-19 22:00:00'),
('AQ-748-UK', 5, '4', '2018-10-04 22:00:00'),
('BB-222-DE', 2, '5', '2018-09-30 22:00:00'),
('BR-363-SJ', 1, '5', '2014-09-03 22:00:00'),
('CF-699-ZE', 5, '4', '2017-02-28 23:00:00'),
('CV-789-XS', 2, '5', '2017-09-06 22:00:00'),
('EY-745-NM', 7, '5', '2018-05-01 22:00:00'),
('FR-657-TX', 8, '4', '2019-01-04 23:00:00'),
('RT-578-CD', 4, '5', '2015-12-31 23:00:00'),
('SE-987-DD', 4, '5', '2015-12-31 23:00:00'),
('SR-163-RJ', 2, '5', '2017-03-31 22:00:00'),
('TB-652-OP', 7, '7', '2019-01-31 23:00:00'),
('TT-123-PM', 6, '4', '2012-12-09 23:00:00'),
('UI-325-FD', 8, '4', '2018-08-03 22:00:00');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `cartegrise`
--
ALTER TABLE `cartegrise`
  ADD PRIMARY KEY (`idProp`,`immat`),
  ADD KEY `fkCarteGriseVoiture` (`immat`);

--
-- Index pour la table `concessionnaire`
--
ALTER TABLE `concessionnaire`
  ADD PRIMARY KEY (`idConces`);

--
-- Index pour la table `modele`
--
ALTER TABLE `modele`
  ADD PRIMARY KEY (`idModele`);

--
-- Index pour la table `proprietaire`
--
ALTER TABLE `proprietaire`
  ADD PRIMARY KEY (`idProp`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`identifiant`);

--
-- Index pour la table `voiture`
--
ALTER TABLE `voiture`
  ADD PRIMARY KEY (`immat`),
  ADD KEY `fkVoitureModele` (`idModele`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `concessionnaire`
--
ALTER TABLE `concessionnaire`
  MODIFY `idConces` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT pour la table `proprietaire`
--
ALTER TABLE `proprietaire`
  MODIFY `idProp` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `cartegrise`
--
ALTER TABLE `cartegrise`
  ADD CONSTRAINT `fkCarteGriseProprietaire` FOREIGN KEY (`idProp`) REFERENCES `proprietaire` (`idProp`),
  ADD CONSTRAINT `fkCarteGriseVoiture` FOREIGN KEY (`immat`) REFERENCES `voiture` (`immat`);

--
-- Contraintes pour la table `voiture`
--
ALTER TABLE `voiture`
  ADD CONSTRAINT `fkVoitureModele` FOREIGN KEY (`idModele`) REFERENCES `modele` (`idModele`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
