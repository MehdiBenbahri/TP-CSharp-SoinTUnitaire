﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoinTUnitaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoinTUnitaire.Tests
{
    [TestClass()]
    public class PrestationTests
    {
        [TestMethod()]
        public void PrestationTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void CompareATest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void SommePourRienTest()
        {
            int a = 3;
            int b = 5;

            Prestation unePrestation = new Prestation("xx", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupond", "Jean"));
            Assert.AreEqual(8, unePrestation.SommePourRien(a, b), "La somme doit être égale à 8");
        }
    }
}


/*
        [TestMethod()]
        public void SommePourRienTest()
        {
            int a = 3;
            int b = 5;
            
            Prestation unePrestation = new Prestation("xx", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupond", "Jean"));
            Assert.AreEqual(8, unePrestation.SommePourRien(a, b), "La somme doit être égale à 8");
        }
    }
}*/
