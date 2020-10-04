using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    class Cruiseschip : Schip
    {
        public int AantalPassagiers { get; set; }
        public List<Haven> Traject { get; set; }

        public Cruiseschip(int aantalPassagiers, List<Haven> traject)
        {
            AantalPassagiers = aantalPassagiers;
            Traject = traject;
        }
    }
}
