using System;
using System.Collections;
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
            pogođenaPolja.Sort((a, b) => a.Redak - b.Redak + a.Stupac - b.Stupac);
            this.mreža = mreža;
        }

        public Polje UputiPucanj()
        {
            Orjentacija o = DajOjentaciju();
            var lista = DajPoljeNastavku(o);
            if (lista.Count() == 1)
            {
                zadnjeGađano = lista.First().First();               
            }
            else
            {
                int index = slučajni.Next(lista.Count());
                zadnjeGađano = lista.ElementAt(index).First();
            }

            return zadnjeGađano;
        }

        private Polje zadnjeGađano;

        private Orjentacija DajOjentaciju()
        {
            if (pogođenaPolja[0].Redak == pogođenaPolja[1].Redak)
                return Orjentacija.Horizontalno;
            return Orjentacija.Vertikalno;
        }

        private IEnumerable<IEnumerable<Polje>> DajPoljeNastavku(Orjentacija orjentacija)
        {
            switch (orjentacija)
            {
                case Orjentacija.Vertikalno:
                    return DajPoljeNastavku(Smjer.Gore, Smjer.Dolje);
                case Orjentacija.Horizontalno:
                    return DajPoljeNastavku(Smjer.Lijevo, Smjer.Desno);
                default:
                    throw new NotImplementedException();
                      
            }
        }

        private IEnumerable<IEnumerable<Polje>> DajPoljeNastavku(Smjer smjer1, Smjer smjer2)
        {
            List<IEnumerable<Polje>> liste = new List<IEnumerable<Polje>>();
            int redak0 = pogođenaPolja[0].Redak;
            int stupca0 = pogođenaPolja[0].Stupac;

            var l1 = mreža.DajPoljaUZadanomSmjeru(redak0, stupca0, smjer1);
            if (l1.Count() > 0)
                liste.Add(l1);

            int n = pogođenaPolja.Count() - 1;
            int redakN = pogođenaPolja[n].Redak;
            int stupcaN = pogođenaPolja[n].Stupac;

            var l2 = mreža.DajPoljaUZadanomSmjeru(redakN, stupcaN, smjer2);
            if (l2.Count() > 0)
                liste.Add(l2);

            return liste;
        }

        List<Polje> pogođenaPolja;
        Mreža mreža;
        Random slučajni = new Random();

        


        public void EvidentirajRezultat(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Polje> PogođenaPolja
        {
            get { throw new NotImplementedException(); }
        }
    }
}
