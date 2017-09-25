using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinTUnitaire
{
    public class Dossier
    {
        //Attribut de la classe Dossier


        private string nomPatient;
        private string prenomPatient;
        private DateTime dateNaissancePatient;
        //La collection est une collection d'objet de la classe Prestation


        private List<Prestation> mesPrestation = new List<Prestation>();

        /// <summary>
        /// Constructeur de base,Initialise un dossier avec une LISTE de prestation.
        /// </summary>
        /// <param name="nPatient"></param>
        /// <param name="pPatient"></param>
        /// <param name="dateNaissPatient"></param>
        /// <param name="maPrest"></param>

        public Dossier(string nPatient, string pPatient, DateTime dateNaissPatient, List<Prestation> maPrest)
        {
            this.NomPatient = nPatient;
            this.PrenomPatient = pPatient;
            this.DateNaissancePatient = dateNaissPatient;
            this.MesPrestation = maPrest;

        }
        /// <summary>
        /// Surcharge du constructeur pour pouvoir Initialiser un dossier sans prestation
        /// </summary>
        /// <param name="nPatient"></param>
        /// <param name="pPatient"></param>
        /// <param name="dateNaissPatient"></param>
        /// 

        public Dossier(string nPatient, string pPatient, DateTime dateNaissPatient)
        {
            this.NomPatient = nPatient;
            this.PrenomPatient = pPatient;
            this.DateNaissancePatient = dateNaissPatient;


        }
        /// <summary>
        /// Surcharge du constructeur pour pouvoir Initialiser un dossier avec une seul prestation
        /// </summary>
        /// <param name="nPatient"></param>
        /// <param name="pPatient"></param>
        /// <param name="dateNaissPatient"></param>
        /// <param name="unePrestation"></param>
        /// 

        public Dossier(string nPatient, string pPatient, DateTime dateNaissPatient, Prestation unePrestation)
        {
            this.NomPatient = nPatient;
            this.PrenomPatient = pPatient;
            this.DateNaissancePatient = dateNaissPatient;
            this.mesPrestation.Add(unePrestation);


        }
        /// <summary>
        /// Utilisé dans le main
        /// </summary>
        /// <returns>Retourne le nombre de prestation executer par un IntervenantExterne</returns>
        /// 

        public int getNbPrestationsExternes()
        {
            int totalNbPrestExt;
            

            totalNbPrestExt = 0;

            foreach (Prestation unePrestation in mesPrestation)
            {
                Intervenant unIntervenant = unePrestation.I_Intervenant1;
                if (unIntervenant is IntervenantExterne)
                {
                    totalNbPrestExt++;
                }
                
            }




            return totalNbPrestExt;
        }

        /// <summary>
        /// Permet d'ajouter unePrestation à un dossier.
        /// </summary>
        /// <param name="unLibelle"></param>
        /// <param name="uneDate"></param>
        /// <param name="unIntervenant"></param>
        /// 

        public void ajoutePrestation(string unLibelle, DateTime uneDate, Intervenant unIntervenant)
        {
            Prestation unePrestation = new Prestation(unLibelle, uneDate, unIntervenant);
            mesPrestation.Add(unePrestation);
        }

        /// <summary>
        /// Fonction getNbJoursSoinsV2
        /// 
        /// </summary>
        /// <returns> retourne le nombre de jour de soin à partir des dates du dossier</returns>
        /// 

        public int getNbJoursSoinsV2()
        {
            DateTime laDate;
            int getNbJour = 0;
            int nbPrestation = MesPrestation.Count;
            var persons = from p in mesPrestation
                          orderby p.DateSoin
                          select p;

            int i = 0;

            while (i < nbPrestation)
            {
                laDate = mesPrestation[i].DateSoin;
                getNbJour++;

                while (i < nbPrestation && mesPrestation[i].DateSoin.Equals(laDate))
                {
                    i = i + 1;
                }

            }

            return getNbJour;
        }

        /// <summary>
        /// Fonction getNbJoursSoinsV1 
        /// 
        /// </summary>
        /// <returns> retourne le nombre de jour de soin à partir des dates du dossier</returns>

        public int getNbJoursSoins()
        {
            DateTime laDate;
            int nbJour = 1;
            int nbPrestation = MesPrestation.Count;
            Prestation laPrestation;

            if (nbPrestation != 0)
            {
                var persons = from p in mesPrestation
                              orderby p.DateSoin
                              select p;

                laDate = mesPrestation[1].DateSoin;
                nbJour++;


                for (int i = 2; i < nbPrestation; i++)
                {

                    laPrestation = mesPrestation[i];

                    if (!laPrestation.DateSoin.Equals(laDate))
                    {

                        nbJour++;
                        laDate = laPrestation.DateSoin;
                    }
                }


            }

            return nbJour;
        }
        //Get/Set
        public string NomPatient { get => nomPatient; set => nomPatient = value; }
        public string PrenomPatient { get => prenomPatient; set => prenomPatient = value; }
        public DateTime DateNaissancePatient { get => dateNaissancePatient; set => dateNaissancePatient = value; }
        public List<Prestation> MesPrestation { get => mesPrestation; set => mesPrestation = value; }
    }
}
