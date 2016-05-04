using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum RezultatGađanja
    {
        Promašaj,
        Pogodak,
        Potonuće
    }
    public class Brod
    {
        public Brod(IEnumerable<Polje> polja)
        {
            this.Polja = polja;
        }

        public int Duljina
        {
            get { return Polja.Count(); }
        }

        public readonly IEnumerable<Polje> Polja;

        public RezultatGađanja Gađaj(Polje p)
        {
            if (!Polja.Contains(p)) return RezultatGađanja.Promašaj;

            pogodjenođenoPolje.Add(p);
            if (pogodjenođenoPolje.Count == Polja.Count()) return RezultatGađanja.Potonuće;
            return RezultatGađanja.Pogodak;

        }

        private HashSet<Polje> pogodjenođenoPolje = new HashSet<Polje>();
    }
}
