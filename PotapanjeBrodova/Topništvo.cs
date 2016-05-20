﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum TaktikaGađanja
    {
        Napipavanje,
        Okruživanje,
        SustavnoUništavanje
    }

    public class Topništvo
    {
        public Topništvo(int readka, int stupaca, int[] duljineBrodova)
        {
            this.duljineBrodova = new List<int>(duljineBrodova);
            this.duljineBrodova.Sort((d1, d2) => d2 - d1);
            mreža = new Mreža(readka, stupaca);
            PromijeniTaktikuUNapipavanje();
        }

        public Polje UputiPucanj()
        {
            return pucać.UputiPucanj();
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            switch (rezultat)
            {
                case RezultatGađanja.Potonuće:
                    PromijeniTaktikuUNapipavanje();
                    break;
                case RezultatGađanja.Pogodak:
                    switch (TrenutnaTaktika)
                    {
                        case TaktikaGađanja.Napipavanje:
                            PromijeniTaktikuUOkruživanje();
                            break;
                        case TaktikaGađanja.Okruživanje:
                            PromijeniTaktikuUSustavnoUništavanje();
                            break;
                        case TaktikaGađanja.SustavnoUništavanje:
                            break;
                        default:
                            Debug.Assert(false, string.Format("Nepodržana taktika {0}", TrenutnaTaktika.ToString()));
                            break;
                    }
                    break;
                case RezultatGađanja.Promašaj:
                    break;
                default:
                    Debug.Assert(false, string.Format("Nepodržani rezultat gađanja {0}", rezultat.ToString()));
                    break;
            }
        }

        private void PromijeniTaktikuUNapipavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Napipavanje;
            pucać = new Napipač(mreža, duljineBrodova[0]);

        }

        private void PromijeniTaktikuUOkruživanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Okruživanje;
        }

        private void PromijeniTaktikuUSustavnoUništavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.SustavnoUništavanje;
        }

        public TaktikaGađanja TrenutnaTaktika
        {
            get;
            private set;
        }

        IPucać pucać;
        Mreža mreža;
        List<int> duljineBrodova;
    }
}
