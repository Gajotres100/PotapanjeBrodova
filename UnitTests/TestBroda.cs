using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace UnitTests
{
    [TestClass]
    public class TestBroda
    {
        [TestMethod]
        public void Brod_GađajVraćaPromašajZaPoljeKojenijeUbrodu()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);

            Assert.AreEqual(RezultatGađanja.Promašaj, b.Gađaj(new Polje(2, 3)));
        }

        [TestMethod]
        public void Brod_GađajVraćaPogodakZaPoljeKojenijeUbrodu()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);

            Assert.AreEqual(RezultatGađanja.Pogodak, b.Gađaj(new Polje(1, 2)));
        }

        [TestMethod]
        public void Brod_GađajVraćaPPotonućeZazadnjePoljeKojenijeUbrodu()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);

            Assert.AreEqual(RezultatGađanja.Pogodak, b.Gađaj(new Polje(1, 2)));
            Assert.AreEqual(RezultatGađanja.Pogodak, b.Gađaj(new Polje(1, 4)));
            Assert.AreEqual(RezultatGađanja.Potonuće, b.Gađaj(new Polje(1, 3)));
        }


        [TestMethod]
        public void Brod_GađajVraćaPogodokaZaPlovilokojejeponovopogođeno()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);

            Assert.AreEqual(RezultatGađanja.Pogodak, b.Gađaj(new Polje(1, 2)));
            Assert.AreEqual(RezultatGađanja.Pogodak, b.Gađaj(new Polje(1, 2)));
        }

        [TestMethod]
        public void Brod_GađajVraćaPPotonućZazadnjepoljekojejeponovnoGađano()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);

            Assert.AreEqual(RezultatGađanja.Pogodak, b.Gađaj(new Polje(1, 2)));
            Assert.AreEqual(RezultatGađanja.Pogodak, b.Gađaj(new Polje(1, 4)));
            Assert.AreEqual(RezultatGađanja.Potonuće, b.Gađaj(new Polje(1, 3)));
            Assert.AreEqual(RezultatGađanja.Potonuće, b.Gađaj(new Polje(1, 4)));
        }
    }
}
