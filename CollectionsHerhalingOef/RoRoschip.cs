using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class RoRoschip : Schip
    {
        public int AantalAutos { get; set; }
        public int AantalTrucks { get; set; }
        public double Cargowaarde { get; set; }

        public RoRoschip(int lengte,int breedte, int tonnage, string naam,int aantalAutos, int aantalTrucks, double cargowaarde) : base(lengte,breedte,tonnage,naam,SchipType.RoRoschip)
        {
            AantalAutos = aantalAutos;
            AantalTrucks = aantalTrucks;
            Cargowaarde = cargowaarde;
        }
    }
}
