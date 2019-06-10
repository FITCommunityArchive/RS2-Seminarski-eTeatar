﻿using System;

namespace DataTransferObjects
{
    public class Termin
    {
        public string Id { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string PredstavaId { get; set; }
        public Dvorana Dvorana { get; set; }
        public double BaznaCijenaKarte { get; set; }
    }
}
