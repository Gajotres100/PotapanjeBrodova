using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucać : IPucać
    {
        public KružniPucać(Polje prvoPogođeno, Mreža m)
        {
            this.PrvoPogođeno = prvoPogođeno;
            this.mreža = mreža;
        }
        public Polje UputiPucanj()
        {
            throw new NotImplementedException();
        }

        Polje PrvoPogođeno;
        Mreža mreža;
    }
}
