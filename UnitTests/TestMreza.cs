using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace UnitTests
{

    [TestClass]
    public class TestMreza
    {
        [TestMethod]
        public void Mreza_DodajSlobodnaPoljaInicijalnaDodajPoljaMrezi()
        {
            Mreza m = new Mreza(10, 10);
            Assert.AreEqual(100, m.DajSlobodnaPolja().Count);
        }

        [TestMethod]
        public void Mreza_DodajSlobodnaNakonEliminiranjaJednogPoljaVracaOstatak()
        {
            Mreza m = new Mreza(10, 10);
            m.EliminirajPolje(1, 1);
            Assert.AreEqual(99, m.DajSlobodnaPolja().Count);
            Assert.IsFalse(m.DajSlobodnaPolja().Exists(polje => polje.Redak == 1 && polje.Stupac == 1));
        }

        [TestMethod]
        public void Mreza_DodajSlobodnaNakonEliminiranjaDvaPoljaVracaOstatak()
        {
            Mreza m = new Mreza(10, 10);
            m.EliminirajPolje(1, 1);
            m.EliminirajPolje(2, 2);
            Assert.AreEqual(98, m.DajSlobodnaPolja().Count);
            Assert.IsFalse(m.DajSlobodnaPolja().Exists(polje => polje.Redak == 1 && polje.Stupac == 1));
            Assert.IsFalse(m.DajSlobodnaPolja().Exists(polje => polje.Redak == 2 && polje.Stupac == 2));
        }

        [TestMethod]
        public void Mreza_DodajSlobodnaNakonEliminiranjaDvaIstaPoljaVracaOstatak()
        {
            Mreza m = new Mreza(10, 10);
            m.EliminirajPolje(1, 1);
            m.EliminirajPolje(2, 2);
            Assert.AreEqual(99, m.DajSlobodnaPolja().Count);
        }
    }
}
