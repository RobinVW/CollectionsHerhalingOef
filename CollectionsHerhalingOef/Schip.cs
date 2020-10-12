using System;

namespace CollectionsHerhalingOef
{
    public abstract class Schip
    {
        public int Lengte { get; set; }
        public int Breedte { get; set; }
        public int Tonnage { get; set; }
        public string Naam { get; set; }

        public Schip(int lengte, int breedte, int tonnage, string naam)
        {
            Lengte = lengte;
            Breedte = breedte;
            Tonnage = tonnage;
            Naam = naam;
        }
    }
}
