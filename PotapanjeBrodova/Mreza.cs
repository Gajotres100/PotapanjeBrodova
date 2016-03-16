using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Mreza
    {
        private Polje[,] polja;
        private int redaka;
        private int stupaca;

        public Mreza(int redaka, int stupaca)
        {
            this.redaka = redaka;
            this.stupaca = stupaca;
            polja = new Polje[redaka, stupaca];
            for (int r = 0; r < redaka; ++r)
            {
                for (int s = 0; s < stupaca; ++s)
                    polja[r, s] = new Polje(r, s);
            }
        }
        public List<Polje> DajSlobodnaPolja()
        {
            List<Polje> slobondaPolja = new List<Polje>();
            for (int r = 0; r < redaka; ++r)
            {
                for (int s = 0; s < stupaca; ++s)
                {
                    if (polja[r, s] != null)
                        slobondaPolja.Add(polja[r, s]);
                }
            }
            return slobondaPolja;
        }

        public void EliminirajPolje(int redak, int stupac)
        {
            polja[redaka, stupac] = null;
        }
    }
}
