using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Vloot
    {
        public string Naam { get; set; }
        public HashSet<Schip> Schepen { get; }

        public Vloot(string naam, HashSet<Schip> schepen)
        {
            Naam = naam;
            Schepen = schepen;
        }

        public Schip ZoekSchipOp(string naamSchip)
        {
            foreach(Schip schip in Schepen)
            {
                if (schip.Naam.Equals(naamSchip, StringComparison.InvariantCultureIgnoreCase))
                {
                    return schip;
                }
            }
            return null;
        }

        public void voegSchipToeAanVloot(Schip schip)
        {
            Schepen.Add(schip);
        }

        public void verwijderSchipUitVloot(Schip schip)
        {
            Schepen.Remove(schip);
        }
    }
}
