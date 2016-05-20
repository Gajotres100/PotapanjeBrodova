using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class TestNapipač
    {
        [TestMethod]
        public void Napipač_ListaPpoljaZaHorizontalniBrodDuljinetriMoraSadržavati15Polja()
        {
            Mreža m = new Mreža(1, 7);
            int duljinaBroda = 3;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(15, n.DajKandidateZaHorizontalniBrod().Count());
        }

        //[TestMethod]
        //public void Napipač_ListaPpoljaZaHorizontalniBrodDuljinetriMoraSadržavatiPoljaUOdređenomBroju()
        //{
        //    Mreža m = new Mreža(1, 7);
        //    int duljinaBroda = 3;
        //    Napipač n = new Napipač(m, duljinaBroda);
        //    Assert.AreEqual(15, n.DajKandidateZaHorizontalniBrod().Count());
        //}

        [TestMethod]
        public void Napipač_ListaPoljaZaVertikalniBrodDuljine4MoraSadržavati16Polja()
        {
            Mreža m = new Mreža(5, 2);
            const int duljinaBroda = 4;
            Napipač n = new Napipač(m, duljinaBroda);
            Assert.AreEqual(16, n.DajKandidateZaVertikalniBrod().Count());
        }
    }
}
