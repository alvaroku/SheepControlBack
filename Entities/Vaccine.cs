﻿namespace Entities
{
    public class Vaccine:ObjetoBase
    {
        public string Name { get; set; }
        public string Observations { get; set; }
        public string IndicatedDose { get; set; } // 1 ml | 12kg
        public string Photo { get; set; }
    }
}
