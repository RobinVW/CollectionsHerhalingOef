using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Olietanker : Schip
    {
        public double Cargowaarde { get; set; }
        public int Volume { get; set; }
        public string Lading { get; set; }

        public Olietanker(int lengte,int breedte,int tonnage, string naam, double cargowaarde, int volume, string lading) : base(lengte,breedte,tonnage,naam)
        {
            Cargowaarde = cargowaarde;
            Volume = volume;
            Lading = lading;
        }
    }
}
