using System.Collections.Generic;

namespace PotapanjeBrodova
{
    public class Flota
    {
        public void DodajBrod(Brod b)
        {
            brodovi.Add(b);
        }

        public IEnumerable<Brod> Brodovi
        {
            get { return brodovi; }
        }

        public int BrojBrodova
        {
            get { return brodovi.Count; }
        }

        public Rezultatgađanja Gađaj(Polje polje)
        {
            foreach(var b in brodovi)
            {
                var rezultat = b.Gađaj(polje);
                if (rezultat != Rezultatgađanja.Promašaj) return rezultat;
            }

            return Rezultatgađanja.Promašaj;
        }

        List<Brod> brodovi = new List<Brod>();
    }
}
