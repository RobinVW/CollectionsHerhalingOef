using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Rederij
    {

        private Dictionary<string, Vloot> Vloten = new Dictionary<string, Vloot>();
        private SortedSet<Haven> Havens = new SortedSet<Haven>();

        public Rederij()
        {

        }

        public void voegVlootToe(Vloot vloot)
        {
            if (!Vloten.ContainsKey(vloot.Naam))
            {
                Vloten.Add(vloot.Naam, vloot);
            }
        }

        public void verwijderVloot(Vloot vloot)
        {
            if (Vloten.ContainsKey(vloot.Naam))
            {
                Vloten.Remove(vloot.Naam);
            }
        }

        public Vloot ZoekVlootOp(string naamVloot)
        {
            if (Vloten.ContainsKey(naamVloot))
            {
                return Vloten[naamVloot];
            }
            return null;
        }

        public SortedDictionary<int,List<Vloot>> tonnagePerVloot()
        {
            //je moet een list van vloten teruggeven aangezien sommige vloten eventueel dezelfde tonnage kunnen hebben
            SortedDictionary<int, List<Vloot>> tonpervloot = new SortedDictionary<int, List<Vloot>>();
            foreach(Vloot v in Vloten.Values)
            {
                int tonnage = v.tonnage();
                if (tonpervloot.ContainsKey(tonnage)) tonpervloot[tonnage].Add(v);
                else
                {
                    tonpervloot.Add(tonnage, new List<Vloot>() { v });
                }
            }
            return tonpervloot;
        }

        public int berekenBeschikbareSleepboten()
        {
            var aantal = 0;
            foreach(Vloot v in Vloten.Values)
            {
                aantal += v.berekenBeschikbareSleepboten();
            }
            return aantal;
        }

       

        public int berekenTotaalVolumeTankers()
        {
            var volume = 0;
            foreach(Vloot v in Vloten.Values)
            {
                var tankers = v.Schepen.Values.OfType<Tanker>();
                volume += tankers.Sum(t => t.Volume);
            }
            return volume;
        }

        public int berekenTotaleCargoWaarde()
        {
            var waarde = 0;
            foreach (Vloot v in Vloten.Values)
            {
                var vrachtSchepen = v.Schepen.Values.OfType<Vrachtschip>();
                waarde += vrachtSchepen.Sum(t => t.Cargowaarde);
            }
            return waarde;

        }

        public void plaatsSchipInAndereVloot(string schipNaam, string vlootNaam)
        {
            Schip s = null;
            foreach(Vloot v in Vloten.Values)
            {
                 s = v.ZoekSchipOp(schipNaam);
            }
            if(s!= null)
            {
                Vloten[s.Vloot.Naam].verwijderSchipUitVloot(s);
                Vloten[vlootNaam].voegSchipToeAanVloot(s);
                s.Vloot = Vloten[vlootNaam];
            }


        }
    }
}
