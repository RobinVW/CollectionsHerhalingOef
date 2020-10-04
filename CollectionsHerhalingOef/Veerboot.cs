using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    class Veerboot : Schip
    {
        public int AantalPassagiers { get; set; }
        public Haven[] Traject { get; set; }

        public Veerboot(int aantalPassagiers, Haven[] traject)
        {
            AantalPassagiers = aantalPassagiers;
            Traject = new Haven[2];
            Traject = traject;
        }
    }
}
