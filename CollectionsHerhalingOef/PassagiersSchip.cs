using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public abstract class PassagiersSchip : Schip
    {
        public int aantalPassagiers { get; set; }

        public Traject traject { get; set; }

        public PassagiersSchip(int lengte, int breedte, int tonnage, string naam, int aantalPassagiers, Traject traject):base(lengte,breedte,tonnage,naam)
        {
            this.aantalPassagiers = aantalPassagiers;
            this.traject = traject;
        }
    }
}
