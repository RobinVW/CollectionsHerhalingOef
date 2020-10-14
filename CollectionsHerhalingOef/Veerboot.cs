using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    class Veerboot : Schip
    {
        public int AantalPassagiers { get; set; }
        public Haven[] Traject { get; set; }

        public Veerboot(int lengte,int breedte,int tonnage, string naam,int aantalPassagiers, Haven[] traject): base(lengte,breedte,tonnage,naam,SchipType.Veerboot)
        {
            AantalPassagiers = aantalPassagiers;
            Traject = new Haven[2];
            Traject = traject;
        }
    }
}
