using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public abstract class Tanker: Vrachtschip
    {
        public int Volume { get; set; }
        public string Lading { get; set; }

        public Tanker(int lengte, int breedte,int tonnage, string naam, int cargowaarde, int volume, string lading): base(lengte,breedte,tonnage,naam,cargowaarde)
        {
            Volume = volume;
            Lading = lading;
        }
    }
}
