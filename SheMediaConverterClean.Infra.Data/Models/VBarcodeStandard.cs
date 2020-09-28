using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VBarcodeStandard
    {
        public int? AufenthaltId { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public int AkteId { get; set; }
        public string Aktennummer { get; set; }
        public string PatientNachname { get; set; }
        public string PatientVorname { get; set; }
        public string Patientennummer { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
        public string StationBezeichnung { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
    }
}
