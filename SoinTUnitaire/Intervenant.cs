using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinTUnitaire
{
    public class Intervenant
    {
        //Attribut
        private string nom;
        private string prenom;
        private List<Prestation> lesPrestations;

        /// <summary>
        /// Constructeur Initial
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="lesPrestations"></param>
        /// 
        public Intervenant(string nom, string prenom, List<Prestation> lesPrestations)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.lesPrestations = lesPrestations;
        }

        /// <summary>
        /// Surcharge du constructeur pour avoir seulement le nom et le prénom de l'intervenant.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// 
        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;

        }

        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public List<Prestation> LesPrestations { get => lesPrestations; }

        public void ajoutePrestation(Prestation unePrestation)
        {

            //lesPrestations.Add(unePrestation);
        }

















    }
}
