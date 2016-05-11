using System.Collections.Generic;

namespace PotapanjeBrodova
{
    // pomoćna klasa koja pojednostavnjuje korištenje rezultata metode IzaberiPočetnoPolje.
    public class PoljeSmjer
    {
        public PoljeSmjer(Orjentacija smjer, Polje polje)
        {
            Smjer = smjer;
            Polje = polje;
        }
        public readonly Polje Polje;
        public readonly Orjentacija Smjer;
    }

    public interface IOdabirPočetnogPoljaZaBrod
    {
        PoljeSmjer IzaberiPočetnoPolje(IEnumerable<Polje> slobodnaPolja, int duljinaBroda);
    }
}
