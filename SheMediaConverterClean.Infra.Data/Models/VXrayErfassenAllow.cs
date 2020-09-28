using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VXrayErfassenAllow
    {
        public int AkteId { get; set; }
        public int PatientId { get; set; }
        public int? AktenTypId { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public string Patientennummer { get; set; }
    }
}
