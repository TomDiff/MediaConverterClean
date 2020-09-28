using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VBarcodeAufenthalt
    {
        public string Patientennummer { get; set; }
        public string PatientNachname { get; set; }
        public string PatientVorname { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
        public string PatientGeburtsname { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public string StationBezeichnung { get; set; }
        public int? HausId { get; set; }
    }
}
