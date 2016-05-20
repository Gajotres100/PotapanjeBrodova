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
        public void KružniPucač_UpućujePucanjUJednoOd4PoljaOkoPoljaUSredini()
        {
            Mreža m = new Mreža(10, 10);
            Polje prvoPogođeno = new Polje(5, 5);
            KružniPucać pucač = new KružniPucać(prvoPogođeno, m);
            List<Polje> kandidati = new List<Polje> { new Polje(4, 5), new Polje(6, 5), new Polje(5, 4), new Polje(5, 6) };
            Assert.IsTrue(kandidati.Contains(pucač.UputiPucanj()));
        }

        [TestMethod]
        public void KružniPucač_UpućujePucanjUJednoOd2PoljaOkoPoljaULijevomGornjemKutu()
        {
            Mreža m = new Mreža(10, 10);
            Polje prvoPogođeno = new Polje(0, 0);
            KružniPucać pucač = new KružniPucać(prvoPogođeno, m);
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1), new Polje(1, 0) };
            Assert.IsTrue(kandidati.Contains(pucač.UputiPucanj()));
        }

        [TestMethod]
        public void KružniPucač_UpućujePucanjUJednoOd2PoljaOkoPoljaUDesnomGornjemKutu()
        {
            Mreža m = new Mreža(10, 10);
            Polje prvoPogođeno = new Polje(0, 9);
            KružniPucać pucač = new KružniPucać(prvoPogođeno, m);
            List<Polje> kandidati = new List<Polje> { new Polje(0, 8), new Polje(1, 9) };
            Assert.IsTrue(kandidati.Contains(pucač.UputiPucanj()));
        }

        [TestMethod]
        public void KružniPucač_UpućujePucanjUJednoOd2PoljaOkoPoljaUDesnomDonjemKutu()
        {
            Mreža m = new Mreža(10, 10);
            Polje prvoPogođeno = new Polje(9, 9);
            KružniPucać pucač = new KružniPucać(prvoPogođeno, m);
            List<Polje> kandidati = new List<Polje> { new Polje(9, 8), new Polje(8, 9) };
            Assert.IsTrue(kandidati.Contains(pucač.UputiPucanj()));
        }

        [TestMethod]
        public void KružniPucač_UpućujePucanjUJednoOd2PoljaOkoPoljaULijevomDonjemKutu()
        {
            Mreža m = new Mreža(10, 10);
            Polje prvoPogođeno = new Polje(9, 0);
            KružniPucać pucač = new KružniPucać(prvoPogođeno, m);
            List<Polje> kandidati = new List<Polje> { new Polje(9, 1), new Polje(8, 0) };
            Assert.IsTrue(kandidati.Contains(pucač.UputiPucanj()));
        }
    }
}
