using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoinTUnitaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinTUnitaire.Tests
{
    [TestClass()]
    public class DossierTests
    {
        

        [TestMethod()]
        public void getNbPrestationsExternesTest()
        {
            DateTime date = new DateTime(1805, 9, 10, 12, 0, 0);
            Dossier unDossier = new Dossier("xx", "yy", date);
            
            
            Intervenant zz = new Intervenant("tt", "ee");
            
            
            unDossier.ajoutePrestation("Libelle P1", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"));
            unDossier.ajoutePrestation("Libelle P2", new DateTime(2015, 9, 8, 12, 0, 0), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            unDossier.ajoutePrestation("Libelle P1", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"));
            unDossier.ajoutePrestation("Libelle P2", new DateTime(2015, 9, 8, 12, 0, 0), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            
            Assert.AreEqual(4, unDossier.getNbJoursSoins(), "");
        }


        [TestMethod()]
        public void getNbJoursSoinsV2Test()
        {
            Intervenant kaaris = new Intervenant("Zongo", "Le Dozo");
            DateTime date = new DateTime(1805, 9, 10, 12, 0, 0);
            
            DateTime date1 = new DateTime(2015, 9, 11, 17, 0, 0);
            DateTime date2 = new DateTime(2016, 10, 15, 12, 0, 0);
            DateTime date4 = new DateTime(2018, 10, 11, 12, 0, 0);



            Dossier unDossier = new Dossier("xx", "yy", date);
            unDossier.ajoutePrestation("1er Prestation", date1, kaaris);
            unDossier.ajoutePrestation("1er Prestation", date2, kaaris);
            unDossier.ajoutePrestation("1er Prestation", date4, kaaris);
            Assert.AreEqual(3, unDossier.getNbJoursSoins(), "résultat attendu: 3 jours de soins (la variable date ne compte pas car c'est la date de naissance du patient");
        }

        [TestMethod()]
        public void getNbJoursSoinsTest()
        {
            DateTime date = new DateTime(2015, 9, 10, 12, 0, 0);

            Dossier unDossier = new Dossier("xx", "yy",date);
            Assert.AreEqual(1, unDossier.getNbJoursSoins(), "résultat attendu: 0 jours de soins");
        }
    }
}