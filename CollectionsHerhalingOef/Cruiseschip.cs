using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Cruiseschip : PassagiersSchip
    {
        public Cruiseschip(int lengte, int breedte, int tonnage, string naam, int aantalPassagiers, Traject traject) : base(lengte,breedte,tonnage,naam,aantalPassagiers,traject)
        {
            
        }
    }
}
