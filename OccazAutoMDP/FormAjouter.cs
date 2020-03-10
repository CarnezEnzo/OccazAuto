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
    public partial class FormAjouter : Form
    {
        private FormAccueil parentForm;
        public FormAjouter(FormAccueil form)
        {
            InitializeComponent();
            this.parentForm = form;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string nom = textNom.Text;
            string prenom = textPrenom.Text;
            string ville = textVille.Text;
            string cp = textCodePostal.Text;
            string adresse = textAdresse.Text;
            if (!string.IsNullOrEmpty(nom) && !string.IsNullOrEmpty(prenom) && !string.IsNullOrEmpty(ville) && !string.IsNullOrEmpty(cp) && !string.IsNullOrEmpty(adresse))
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
                    int reader = MySQLOutil.insertConcessionnaire(nom, prenom, adresse, cp, ville, cnx);
                    if (reader != 0)
                    {
                        MessageBox.Show("Nouveau concessionnaire ajoutée!");
                        this.Close();
                    }
                    cnx.Close();
                }
                else
                {
                    MessageBox.Show("Impossible de joindre la base de données!");
                }
            }
            else
            {
                MessageBox.Show("Merci de renseigner tous les champs.");
            }
            this.parentForm.loadDataBase();
            this.parentForm.setListViewDisplay(this.parentForm.getLesConcessionnaires());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.clearLesChamps();
        }

        /// <summary>
        /// Permet de vider les champs de modification
        /// </summary>
        private void clearLesChamps()
        {
            textNom.Clear();
            textPrenom.Clear();
            textVille.Clear();
            textCodePostal.Clear();
            textAdresse.Clear();
        }
    }
}
