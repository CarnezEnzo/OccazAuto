using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccazAutoMDP
{
    public class Concessionnaire
    {
        private int id;
        private string adresse;
        private string cp;    
        private string nom;
        private string prenom;
        private string ville;

        public Concessionnaire(int id, string adresse, string cp, string nom, string prenom, string ville)
        {
            this.Id = id;
            this.Adresse = adresse;
            this.Cp = cp;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Ville = ville;
        }

        public int Id { get => id; set => id = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Ville { get => ville; set => ville = value; }

        public bool Rechercher(string nom = "", string ville = "", string cp = "")
        {
            return (!string.IsNullOrEmpty(nom) && this.nom.ToLower().StartsWith(nom.ToLower()) ||
                 !string.IsNullOrEmpty(ville) && this.ville.ToLower().StartsWith(ville.ToLower()) ||
                 !string.IsNullOrEmpty(cp) && this.cp.ToLower().StartsWith(cp.ToLower()));
        }

    }
}
