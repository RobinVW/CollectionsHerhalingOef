using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Containerschip : Vrachtschip
    {
        public int AantalContainers { get; set; }

        public Containerschip(int lengte, int breedte, int tonnage, string naam, int aantalContainers, double cargowaarde) : base(lengte, breedte, tonnage, naam, SchipType.Containerschip)
        { 
            AantalContainers = aantalContainers;
        }
    }
}
