using System;

namespace CollectionsHerhalingOef
{
    public abstract class Schip
    {
        public enum SchipType { Containerschip, Cruiseschip, Gastanker, Olietanker, RoRoschip, Sleepboot, Veerboot}

        public int Lengte { get; set; }
        public int Breedte { get; set; }
        public int Tonnage { get; set; }
        public string Naam { get; set; }
        public SchipType Type { get; }

        public Schip(int lengte, int breedte, int tonnage, string naam, SchipType type)
        {
            Lengte = lengte;
            Breedte = breedte;
            Tonnage = tonnage;
            Naam = naam;
            Type = type; 
        }
    }
}
