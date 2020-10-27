using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Rederij
    {

        public SortedSet<Vloot> Vloten { get; set; }
        public double TotaleCargoSchepen { get; set; }

        public Rederij(SortedSet<Vloot> vloten)
        {
            Vloten = new SortedSet<Vloot>(new VlootComparer());
            Vloten = vloten;
        }

        public void voegVlootToe(Vloot vloot)
        {
            Vloten.Add(vloot);
        }

        public void verwijderVloot(Vloot vloot)
        {
            Vloten.Remove(vloot);
        }

        public Vloot ZoekVlootOp(string naamVloot)
        {
            foreach (Vloot vloot in Vloten)
            {
                if (vloot.Naam.Equals(naamVloot, StringComparison.InvariantCultureIgnoreCase))
                {
                    return vloot;
                }
            }
            return null;
        }

        public double berekenTotaleCargo()
        {

            foreach (Vloot vloot in Vloten)
            {
                foreach (Schip schip in vloot.Schepen)
                {
                    var type = schip.Type;
                    var schipMetType = schip as type;
                    if ( (type)schip)
                    { 
                        TotaleCargoSchepen += schip.Cargowaarde;
                    }
                }
            }
            return TotaleCargoSchepen;
        }

        public int berekenBeschikbareSleepboten()
        {
            int beschikbareSleepboten = 0;

            foreach (Vloot vloot in Vloten)
            {
                Schip[] schepenArray = new Schip[vloot.Schepen.Count];
                vloot.Schepen.CopyTo(schepenArray);
                beschikbareSleepboten += schepenArray.ToList().Cast<Sleepboot>().Count();
            }

            return beschikbareSleepboten;
        }

        public Schip toonSchipInfo(String naamSchip)
        {
            foreach (Vloot vloot in Vloten)
            {
                foreach (Schip schip in vloot.Schepen)
                {
                    if (schip.Naam.Equals(naamSchip, StringComparison.InvariantCultureIgnoreCase))
                        return schip;
                }
            }
            return null;
        }

        public int berekenTotaalVolumeTankers()
        {
            int totaalVolumeTankers = 0;

            foreach (Vloot vloot in Vloten)
            {
                Schip[] schepenArray = new Schip[vloot.Schepen.Count];
                vloot.Schepen.CopyTo(schepenArray);
                var schepenList = schepenArray.ToList();
                var gastankerList = schepenList.Cast<Gastanker>().ToList();
                var olietankerList = schepenList.Cast<Olietanker>().ToList();

                foreach (Gastanker tanker in gastankerList)
                {
                    totaalVolumeTankers += tanker.Volume;
                }

                foreach (Olietanker tanker in olietankerList)
                {
                    totaalVolumeTankers += tanker.Volume;
                }
            }

            return totaalVolumeTankers;

        }

        public List<int> berekenTonnagePerVloot()
        {
            List<int> vlotenTonnageLijst = new List<int>();
            foreach(Vloot vloot in Vloten)
            {
                int vlootTonnage = 0;
                foreach(Schip schip in vloot.Schepen)
                {
                    vlootTonnage += schip.Tonnage;
                }
                vlotenTonnageLijst.Add(vlootTonnage);
            }
            vlotenTonnageLijst = vlotenTonnageLijst.OrderByDescending(d => d).ToList();

            return vlotenTonnageLijst;
        }



        internal class VlootComparer : IComparer<Vloot>
        {
            public int Compare(Vloot x, Vloot y)
            {
                int result = x.Naam.CompareTo(y.Naam);
                return result;
            }
        }




    }
}
