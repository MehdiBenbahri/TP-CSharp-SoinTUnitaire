using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinTUnitaire
{
    public class Prestation
    {
        //Note: L'attribut heureSoin doit être de type heure,à voir si on ne peut pas faire avec 
        //La Structure DateTime...
        private string libelle;
        private DateTime dateSoin;
        private Intervenant I_Intervenant;

        //Constructeur de la classe Préstation
        public Prestation(string lib, DateTime dateSoin, Intervenant I_inter)
        {
            this.libelle = lib;
            this.dateSoin = dateSoin;
            this.I_Intervenant = I_inter;
            //La classe Prestation à la responsabilité d'instancier cette collection (voir Exo 2) 
            I_inter.ajoutePrestation(this);
        }

        public string Libelle { get => libelle; }
        public DateTime DateSoin { get => dateSoin; set => dateSoin = value; }
        public Intervenant I_Intervenant1 { get => I_Intervenant; }

        /// <summary>
        /// Permet de comparer des date via la méthode Compare
        /// </summary>
        /// <param name="unePrestation"></param>
        /// <returns>retourne 0 si les date sont égaux,1 si la 2ème est postérieur,et -1 si la 2ème est inférieur</returns>
        public int CompareA(Prestation unePrestation)
        {
            int c = DateTime.Compare(this.dateSoin, unePrestation.DateSoin);
            return c;


        }

        public int SommePourRien (int a,int b)
        {



            return a + b;
        }


    }
}
