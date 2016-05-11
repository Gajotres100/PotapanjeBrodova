using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class SustavniPucać : IPucać
    {
        public SustavniPucać(IEnumerable<Polje> pogođena, Mreža mreža)
        {
            pogođenaPolja = new List<Polje>(pogođena);
            this.mreža = mreža;
        }

        List<Polje> pogođenaPolja;
        Mreža mreža;
    }
}
