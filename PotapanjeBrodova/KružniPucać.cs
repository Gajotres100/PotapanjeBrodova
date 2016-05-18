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
            this.mreža = m;
        }
        public Polje UputiPucanj()
        {
            int redak = PrvoPogođeno.Redak;
            int stupac = PrvoPogođeno.Stupac;

            List<IEnumerable<Polje>> kandidati = new List<IEnumerable<Polje>>();

            foreach (Smjer smjer in Enum.GetValues(typeof(Smjer)))
                mreža.DajPoljaUZadanomSmjeru(redak, stupac, smjer);
            
            kandidati.Sort((lista1, lista2) => lista2.Count() - lista1.Count());
            var grupe = kandidati.GroupBy(lista => lista.Count());

            var najdulji = grupe.First();

            if(najdulji.Count() == 0)
                return najdulji.First().First();

            int indeks = slučajni.Next(0, najdulji.Count());

            return najdulji.ElementAt(indeks).First();            
        }

        Polje PrvoPogođeno;
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
