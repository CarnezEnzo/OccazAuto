using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OccazAutoMDP
{
    public partial class FormAccueil : System.Windows.Forms.Form
    {
        private List<Concessionnaire> lesConcessionnaires;
        int modif = 0;

        public FormAccueil()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.comboBoxCritere.SelectedIndex = 0;        
            this.loadDataBase();
            this.setListViewDisplay(this.lesConcessionnaires);
            
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            makeSearch();
        }

        private void textBoxCritere_TextChanged(object sender, EventArgs e)
        {
            makeSearch();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.FermerFormulaire();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (this.listViewAffichage.SelectedItems.Count > 0)
            {
                ListViewItem item = this.listViewAffichage.SelectedItems[0];
                int id = int.Parse(item.Text);
                this.removeFromDataBase(id);
                Concessionnaire cons = this.getConcessionnaireFromId(id);
                if (cons != null) {
                    this.lesConcessionnaires.Remove(cons);
                }
                this.setListViewDisplay(this.lesConcessionnaires);
            }
            else
            {
                MessageBox.Show("Merci de selectionner une ligne.");
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            
            Concessionnaire cons = getCurrentSelectedConcessionnaire();
            if (cons != null)
            {
                panelModification.Visible = true;
                this.modif = cons.Id;
                textNom.Text = cons.Nom;
                textPrenom.Text = cons.Prenom;
                textAdresse.Text = cons.Adresse;
                textCodePostal.Text = cons.Cp;
                textVille.Text = cons.Ville;
            }
            else
            {
                MessageBox.Show("Aucune ligne selectionnée pour effectuer une modification...");
            }
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Concessionnaire cons = this.getConcessionnaireFromId(this.modif);
            cons.Nom = textNom.Text;
            cons.Prenom = textPrenom.Text;
            cons.Adresse = textAdresse.Text;
            cons.Cp = textCodePostal.Text;
            cons.Ville = textVille.Text;
            this.updateDataBase(cons);
            this.setListViewDisplay(this.lesConcessionnaires);
            panelModification.Visible = false;
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string identifiant = textBoxIdentifiant.Text;
            string mdp = textBoxMotDePasse.Text;
            if (!string.IsNullOrEmpty(identifiant) && !string.IsNullOrEmpty(mdp))
            {
                MySqlConnection cnx = MySQLOutil.createNewConnection();
                bool connected = true;
                bool valid = false;
                try
                {
                    cnx.Open();
                }
                catch (MySqlException)
                {
                    connected = false;
                }

                if (connected)
                {
                    MySqlDataReader reader = MySQLOutil.selectUser(identifiant, mdp, cnx);
                    valid = reader.HasRows;
                    reader.Close();
                    cnx.Close();
                }
                else
                {
                    MessageBox.Show("Impossible de joindre la base de données!");
                }
                if (valid)
                {
                    MessageBox.Show("Vous êtes connecté");
                    panelConnexion.Visible = false;
                }
                else
                    MessageBox.Show("Identifiants invalides! Re-essayez");
            }
            else
                MessageBox.Show("Identifiants non saisis! Re-essayez");
        }

        private void buttonInscription_Click(object sender, EventArgs e)
        {
            string identifiant = textBoxIdentifiant.Text;
            string mdp = textBoxMotDePasse.Text;
            if (!string.IsNullOrEmpty(identifiant) && !string.IsNullOrEmpty(mdp))
            {
                MySqlConnection cnx = MySQLOutil.createNewConnection();
                bool connected = true;
                try
                {
                    cnx.Open();
                }
                catch (MySqlException)
                {
                    connected = false;
                }

                if (connected)
                {
                    int reader = MySQLOutil.insertUser(identifiant, mdp, cnx);
                    cnx.Close();
                    if (reader == 1)
                    {
                        MessageBox.Show("Vous êtes désormais inscrit!");
                        panelConnexion.Visible = false;
                    }
                    else
                        MessageBox.Show("Identifiants déjà utilisés! Re-essayez");
                }
                else
                {
                    MessageBox.Show("Impossible de joindre la base de données!");
                }
            }
            else
                MessageBox.Show("Identifiants non saissi! Re-essayez");
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            AfficherFormAjout();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherFormAjout();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FermerFormulaire();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Annuler();
        }

        /// <summary>
        /// Permet d'obtenir la liste des concessionnaires
        /// </summary>
        /// <returns></returns>
        public List<Concessionnaire> getLesConcessionnaires()
        {
            return this.lesConcessionnaires;
        }

        /// <summary>
        /// Permet de faire une recherche sur les concessionnaires
        /// </summary>
        private void makeSearch()
        {
            if (!string.IsNullOrEmpty(this.textBoxCritere.Text))
            {
                List<Concessionnaire> nouvelleList = new List<Concessionnaire>();
                foreach (Concessionnaire conc in this.lesConcessionnaires)
                {
                    if (this.comboBoxCritere.SelectedIndex == 0 && conc.Rechercher(ville: this.textBoxCritere.Text))
                        nouvelleList.Add(conc);
                    else if (this.comboBoxCritere.SelectedIndex == 1 && conc.Rechercher(nom: this.textBoxCritere.Text))
                        nouvelleList.Add(conc);
                    else if (this.comboBoxCritere.SelectedIndex == 2 && conc.Rechercher(cp: this.textBoxCritere.Text))
                        nouvelleList.Add(conc);
                }
                this.setListViewDisplay(nouvelleList);
            }
            else
                this.setListViewDisplay(this.lesConcessionnaires);
        }

        /// <summary>
        /// Permet d'actualiser la liste des concessionnaires
        /// </summary>
        /// <param name="uneListe"></param>
        public void setListViewDisplay(List<Concessionnaire> uneListe)
        {
            listViewAffichage.Items.Clear();
            foreach (Concessionnaire conc in uneListe)
            {
                var item = new ListViewItem(new[] { conc.Id.ToString(), conc.Nom, conc.Prenom, conc.Adresse, conc.Cp, conc.Ville });
                listViewAffichage.Items.Add(item);
            }
        }

        /// <summary>
        /// Permet de fermer le formulaire
        /// </summary>
        private void FermerFormulaire()
        {
            this.Close();
        }

        /// <summary>
        /// Permet d'annuler la modification
        /// </summary>
        private void Annuler()
        {
            textNom.Clear();
            textPrenom.Clear();
            textAdresse.Clear();
            textCodePostal.Clear();
            textVille.Clear();
            panelModification.Visible = false;
        }

        /// <summary>
        /// Permet d'afficher le formulaire d'ajout
        /// </summary>
        private void AfficherFormAjout()
        {
            FormAjouter form = new FormAjouter(this);
            form.Show();
        }

        /// <summary>
        /// Retourne un concessionnaire depuis son ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Concessionnaire getConcessionnaireFromId(int id)
        {
            foreach (Concessionnaire cons in this.lesConcessionnaires)
            {
                if (cons.Id == id)
                {
                    return cons;
                }
            }

            return null;
        }

        /// <summary>
        /// Retourne le concessionnaire actuel
        /// </summary>
        /// <returns>Le concessionnaire actuel</returns>
        private Concessionnaire getCurrentSelectedConcessionnaire()
        {
            if (this.listViewAffichage.SelectedItems.Count > 0)
            {
                ListViewItem item = this.listViewAffichage.SelectedItems[0];
                int id = int.Parse(item.Text);
                return getConcessionnaireFromId(id);
            }
            return null;
        }

        /// <summary>
        /// Retire un utilisateur de la base de donnée
        /// </summary>
        /// <param name="id">L'ID de l'utilisateur à supprimer</param>
        private void removeFromDataBase(int id)
        {

            MySqlConnection cnx = MySQLOutil.createNewConnection();
            bool connected = true;
            try
            {
                cnx.Open();
            }
            catch (MySqlException)
            {
                connected = false;
            }

            if (connected)
            {
                int reader = MySQLOutil.deleteConcessionnaire(id, cnx);
                cnx.Close();
            }
        }

        /// <summary>
        /// Permet de charger la base de donnée dans la liste
        /// </summary>
        public void loadDataBase()
        {
            this.lesConcessionnaires = new List<Concessionnaire>();
            MySqlConnection cnx = MySQLOutil.createNewConnection();
            bool connected = true;
            try
            {
                cnx.Open();
            }
            catch (MySqlException)
            {
                connected = false;
            }

            if (connected)
            {
                MySqlDataReader reader = MySQLOutil.selectAll("concessionnaire", cnx);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.lesConcessionnaires.Add(new Concessionnaire((int)reader["idConces"], (string)reader["adresse"],
                            (string)reader["codepostal"], (string)reader["nom"], (string)reader["prenom"], (string)reader["ville"]));
                    }
                }
                reader.Close();
                cnx.Close();
            }
            else
            {
                MessageBox.Show("Attention! Impossible de joindre la base de données!");
            }
        }

        /// <summary>
        /// Permet de mettre à jour la base de donnée
        /// </summary>
        /// <param name="cons"></param>
        private void updateDataBase(Concessionnaire cons)
        {
            MySqlConnection cnx = MySQLOutil.createNewConnection();
            bool connected = true;
            try
            {
                cnx.Open();
            }
            catch (MySqlException)
            {
                connected = false;
            }

            if (connected)
            {
                int reader = MySQLOutil.updateConcessionnaire(cons, cnx);
                cnx.Close();
            }
            else
            {
                MessageBox.Show("Attention! Impossible de joindre la base de données!");
            }
        }
    }
}
