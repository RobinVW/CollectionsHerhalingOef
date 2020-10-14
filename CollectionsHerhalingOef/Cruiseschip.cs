using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Cruiseschip : Schip
    {
        public int AantalPassagiers { get; set; }
        public List<Haven> Traject { get; set; }

        public Cruiseschip(int lengte, int breedte, int tonnage, string naam, int aantalPassagiers, List<Haven> traject) : base(lengte,breedte,tonnage,naam, SchipType.Cruiseschip)
        {
            AantalPassagiers = aantalPassagiers;
            Traject = traject;
        }
    }
}
