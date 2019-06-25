﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LektuvuAtaskaitos_bussinessLogic
{
    public class ReportItem
    {
        public string AircraftTailNumber { get; set; }
        public string ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public string OwnerCompanyName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }
        public bool? BelongsToEU { get; set; }
        public string BelongsToES { get; set; }
    }
}
