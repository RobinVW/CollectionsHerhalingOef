using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CollectionsHerhalingOef
{
    public abstract class Vrachtschip : Schip
    {
        public int Cargowaarde { get; set; }

        protected Vrachtschip(int lengte, int breedte,int tonnage,string naam,  int cargowaarde) : base(lengte,breedte,tonnage,naam)
        {
            Cargowaarde = cargowaarde;
        }
    }
}
