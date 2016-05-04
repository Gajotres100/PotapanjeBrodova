using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TestKružniPucać
    {
        [TestMethod]
        public void KružniPucać_UpučujePucanjUJednoOdČetriOkolnjihPolja()
        {
            Mreža m = new Mreža(10,10);
            Polje  prvoPogođeno = new Polje(5,6);
            KružniPucać pucać = new KružniPucać(prvoPogođeno, m);
            List<Polje> kadidati = new List<Polje> {new Polje(4,5) ,new Polje(6,5), new Polje(5,5), new Polje (5,4) };
            Assert.IsTrue(kadidati.Contains(pucać.UputiPucanj()));
            pucać.UputiPucanj();
        }
    }
}
