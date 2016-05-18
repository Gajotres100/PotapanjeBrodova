using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Napipač : IPucać
    {
        public Napipač(Mreža mreža, int duljinaBroda)
        {
            this.mreža = mreža;
            this.duljinaBroda = duljinaBroda;
        }
        public Polje UputiPucanj()
        {
            List<Polje> polja = DajKandidateZaHorizontalniBrod().ToList();
            polja.AddRange(DajKandidateZaVertikalniBrod());

            int index = slučajno.Next(0, polja.Count());
            return polja[index];
        }

        private Mreža mreža;
        private int duljinaBroda;
        private Random slučajno = new Random();


        public IEnumerable<Polje> DajKandidateZaHorizontalniBrod()
        {
            List<Polje> kadidati = new List<Polje>();
            var slobodna = mreža.DajSlobodnaPolja();

            for (int r = 0; r < mreža.Redaka; ++r )
            {
                int brojacPolja = 0;
                for(int s = 0; s < mreža.Stupaca; ++s)
                {
                    Polje p = new Polje(r, s);
                    if (slobodna.Contains(p))
                    {
                        ++brojacPolja;
                    }
                    else
                    {
                        brojacPolja = 0;
                    }
                    if(brojacPolja >= duljinaBroda)
                    {
                        for (int ss = s - duljinaBroda; ss < s; ++ss)
                            kadidati.Add(new Polje(r, ss));
                    }
                }
            }

             return kadidati;
        }

        public IEnumerable<Polje> DajKandidateZaVertikalniBrod()
        {
            List<Polje> kadidati = new List<Polje>();
            var slobodna = mreža.DajSlobodnaPolja();

            for (int s = 0; s < mreža.Stupaca; ++s)
            {
                int brojacPolja = 0;
                for (int r = 0; r < mreža.Redaka; ++r)
                {
                    Polje p = new Polje(r, s);
                    if (slobodna.Contains(p))
                    {
                        ++brojacPolja;
                    }
                    else
                    {
                        brojacPolja = 0;
                    }
                    if (brojacPolja >= duljinaBroda)
                    {
                        for (int rr = r - duljinaBroda + 1; rr <= r; ++rr)
                            kadidati.Add(new Polje(rr, s));
                    }
                }
            }

            return kadidati;
        }


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
