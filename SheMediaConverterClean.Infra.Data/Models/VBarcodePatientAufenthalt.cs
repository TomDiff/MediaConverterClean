using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VBarcodePatientAufenthalt
    {
        public string AufenthaltNr { get; set; }
        public int PatientId { get; set; }
        public string PatientenNr { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Geburtsname { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public bool? StationId { get; set; }
        public int? HausId { get; set; }
    }
}
