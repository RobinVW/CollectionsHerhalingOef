using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Vloot
    {
        public string Naam { get; set; }
        public Dictionary<string, Schip> Schepen = new Dictionary<string, Schip>();

        public Vloot(string naam, Dictionary<string, Schip> schepen)
        {
            Naam = naam;
            Schepen = schepen;
        }

        public Schip ZoekSchipOp(string naamSchip)
        {
            if (Schepen.ContainsKey(naamSchip))
            {
                var schip = Schepen[naamSchip];
                return schip;
            }
            return null;
        }

        public void voegSchipToeAanVloot(Schip schip)
        {
            if (!Schepen.ContainsKey(schip.Naam))
            {
                Schepen.Add(schip.Naam, schip);
                schip.Vloot = this;
            }
        }

        public void verwijderSchipUitVloot(Schip schip)
        {
            if (Schepen.ContainsKey(schip.Naam))
            {
                Schepen.Remove(schip.Naam);
                schip.Vloot = null;
            }
        }

        public int passagiers()
        {
            int p = 0;
            foreach(Schip s in Schepen.Values)
            {
                if (s is PassagiersSchip) p += ((PassagiersSchip)s).aantalPassagiers;
            }
            return p;
        }

        public int tonnage()
        {
            var tonnage = 0;
            foreach(Schip s in Schepen.Values)
            {
                tonnage += s.Tonnage;
            }
            return tonnage;
        }

        public int berekenBeschikbareSleepboten()
        {
            var aantal = Schepen.Values.OfType<Sleepboot>().Count();
            return aantal;
        }
    }
}
