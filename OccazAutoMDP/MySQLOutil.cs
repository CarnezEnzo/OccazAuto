using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OccazAutoMDP
{
    class MySQLOutil
    {
        /// <summary>
        /// Permet de créer une connexion
        /// </summary>
        /// <returns>Retourne une connexion</returns>
        static public MySqlConnection createNewConnection()
        {
            string chaineCnx = "SERVER=127.0.0.1; DATABASE=bdOccasion; UID=root; PASSWORD=root";
            return new MySqlConnection(chaineCnx);
        }

        /// <summary>
        /// Selectionne tous les elements d'une table
        /// </summary>
        /// <param name="table">La table à selectionner</param>
        /// <param name="cnx">Une connexion</param>
        /// <returns>Retourne tous les elements de la table</returns>
        static public MySqlDataReader selectAll(string table, MySqlConnection cnx)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM {table}", cnx);
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// Selectionne tous les utilisateurs basé sur des paramètres
        /// </summary>
        /// <param name="identifiant"></param>
        /// <param name="mdp"></param>
        /// <param name="cnx"></param>
        /// <returns>Retourne un reader de tous les utilisateurs basé sur les paramètres</returns>
        static public MySqlDataReader selectUser(string identifiant, string mdp, MySqlConnection cnx)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM utilisateur WHERE identifiant='{identifiant}' AND motdepasse='{mdp}'", cnx);
            return cmd.ExecuteReader();
        }

        /// <summary>
        /// Ajoute un utilisateur à la base de données.
        /// </summary>
        /// <param name="identifiant"></param>
        /// <param name="mdp"></param>
        /// <param name="cnx"></param>
        /// <returns>Retourne le nombre de modifications</returns>
        static public int insertUser(string identifiant, string mdp, MySqlConnection cnx)
        {
            MySqlCommand cmd = new MySqlCommand($"INSERT IGNORE INTO utilisateur(identifiant, motdepasse) VALUES('{identifiant}', '{mdp}')", cnx);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Supprime un concessionnaire basé sur son id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cnx"></param>
        /// <returns>Retourne le nombre de modifications.</returns>
        static public int deleteConcessionnaire(int id, MySqlConnection cnx)
        {
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM concessionnaire WHERE idConces={id}", cnx);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Permet de mettre à jour les concessionnaires.
        /// </summary>
        /// <param name="cons"></param>
        /// <param name="cnx"></param>
        /// <returns>Le nombre de moficiations.</returns>
        static public int updateConcessionnaire(Concessionnaire cons, MySqlConnection cnx)
        {
            MySqlCommand cmd = new MySqlCommand($"UPDATE concessionnaire SET " +
                $"prenom='{cons.Prenom}', nom='{cons.Nom}', adresse='{cons.Adresse}', codepostal='{cons.Cp}', ville='{cons.Ville}'" +
                $"WHERE idConces='{cons.Id}'", cnx);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Permet d'ajouter une concessionnaire.
        /// </summary>
        /// <param name="nom">Le nom</param>
        /// <param name="prenom">Le prenom</param>
        /// <param name="adresse">L'adresse</param>
        /// <param name="cp">Le code postal</param>
        /// <param name="ville">La ville</param>
        /// <param name="cnx">La connexion</param>
        /// <returns>Le nombre de moficiations.</returns>
        static public int insertConcessionnaire(string nom, string prenom, string adresse, string cp, string ville, MySqlConnection cnx)
        {
            MySqlCommand cmd = new MySqlCommand($"INSERT IGNORE INTO Concessionnaire(nom, prenom, adresse, codePostal, ville) VALUES('{nom}', '{prenom}', '{adresse}', '{cp}', '{ville}')", cnx);
            return cmd.ExecuteNonQuery();
        }
    }
}
