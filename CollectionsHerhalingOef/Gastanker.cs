﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsHerhalingOef
{
    public class Gastanker : Schip
    {
        public double Cargowaarde { get; set; }
        public int Volume { get; set; }
        public string Lading { get; set; }

        public Gastanker(int lengte,int breedte, int tonnage, string naam,double cargowaarde, int volume, string lading) : base(lengte,breedte,tonnage,naam,SchipType.Gastanker)
        {
            Cargowaarde = cargowaarde;
            Volume = volume;
            Lading = lading;
        }
    }
}
