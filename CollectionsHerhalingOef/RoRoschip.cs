using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class RoRoschip : Vrachtschip
    {
        public int AantalAutos { get; set; }
        public int AantalTrucks { get; set; }

        public RoRoschip(int lengte,int breedte, int tonnage, string naam,int aantalAutos, int aantalTrucks, double cargowaarde) : base(lengte,breedte,tonnage,naam,cargowaarde)
        {
            AantalAutos = aantalAutos;
            AantalTrucks = aantalTrucks;
            
        }
    }
}
