using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Containerschip : Schip
    {
        public int AantalContainers { get; set; }
        public double Cargowaarde { get; set; }

        public Containerschip(int lengte, int breedte, int tonnage, string naam, int aantalContainers, double cargowaarde) : base(lengte, breedte, tonnage, naam)
        { 
            AantalContainers = aantalContainers;
            Cargowaarde = cargowaarde;
        }
    }
}
