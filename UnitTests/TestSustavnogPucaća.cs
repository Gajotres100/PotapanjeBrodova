using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TestSustavnogPucaća
    {
        [TestMethod]
        public void SustavniPucać_uputiPucanjVraćaLjevoDesnoPoljeHorizontalniSmjer()
        {
            List<Polje> pogođenaPolja = new List<Polje> { new Polje(3, 2), new Polje(3, 3) };
            Mreža mreža = new Mreža(10, 10);

            SustavniPucać p = new SustavniPucać(pogođenaPolja, mreža);

            List<Polje> kandidati = new List<Polje> { new Polje(3, 1), new Polje(3, 4) };

            p.UputiPucanj();

            Assert.IsTrue(kandidati.Contains(p.UputiPucanj()));
        }

        [TestMethod]
        public void SustavniPucać_uputiPucanjVraćaGoreDoljePoljeVertikalniSmjer()
        {
            List<Polje> pogođenaPolja = new List<Polje> { new Polje(2, 2), new Polje(3, 2) };
            Mreža mreža = new Mreža(10, 10);

            SustavniPucać p = new SustavniPucać(pogođenaPolja, mreža);

            List<Polje> kandidati = new List<Polje> { new Polje(1, 2), new Polje(4, 2) };

            p.UputiPucanj();

            Assert.IsTrue(kandidati.Contains(p.UputiPucanj()));
        }

        [TestMethod]
        public void SustavniPucać_uputiPucanjVraćaDonjePoljeZaVertikalniSmjer()
        {
            List<Polje> pogođenaPolja = new List<Polje> { new Polje(0, 2), new Polje(1, 2) };
            Mreža mreža = new Mreža(10, 10);

            SustavniPucać p = new SustavniPucać(pogođenaPolja, mreža);

            p.UputiPucanj();

            Assert.AreEqual(new Polje(2,2), p.UputiPucanj());
        }

        [TestMethod]
        public void SustavniPucać_uputiPucanjVraćaDesnoPoljeZaHorzinontaLismjerAkoJeLjevoPoljeVećElmininirano()
        {
            List<Polje> pogođenaPolja = new List<Polje> { new Polje(3, 2), new Polje(3, 3) };
            Mreža mreža = new Mreža(10, 10);
            mreža.EliminirajPolje(3, 1);

            SustavniPucać p = new SustavniPucać(pogođenaPolja, mreža);

            List<Polje> kandidati = new List<Polje> { new Polje(3, 4) };

            //p.UputiPucanj();

            Assert.IsTrue(kandidati.Contains(p.UputiPucanj()));
        }
    }
}
