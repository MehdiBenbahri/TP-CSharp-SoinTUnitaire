﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinTUnitaire
{
    public class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        /// <summary>
        /// Constructeur initial
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="lesPrestations"></param>
        /// <param name="specialite"></param>
        /// <param name="adresse"></param>
        /// <param name="tel"></param>
        /// 
        public IntervenantExterne(string nom, string prenom, List<Prestation> lesPrestations, string specialite, string adresse, string tel) : base(nom, prenom, lesPrestations)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        /// <summary>
        /// Surcharge du constructeur pour pouvoir utiliser la surcharge du constructeur de la classe mère
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="specialite"></param>
        /// <param name="adresse"></param>
        /// <param name="tel"></param>
        /// 
        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel) : base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }


        /// <summary>
        /// Get/Set
        /// </summary>
        /// 
        public string Specialite { get => specialite; }
        public string Adresse { get => adresse; }
        public string Tel { get => tel; }
    }

}
