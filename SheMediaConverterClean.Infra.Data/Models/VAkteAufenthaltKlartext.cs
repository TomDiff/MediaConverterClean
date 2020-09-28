using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAkteAufenthaltKlartext
    {
        public string PatientNachname { get; set; }
        public string PatientVorname { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public int? PapieraktenStatus { get; set; }
        public int? FreigabeStatus { get; set; }
        public int? ElektronischerStatus { get; set; }
        public int? VerarbeitungsStatus { get; set; }
        public int? EingangsMahnstufe { get; set; }
        public string Aktennummer { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public string Patientennummer { get; set; }
        public string LagerortBezeichnung { get; set; }
        public DateTime? Eingangsdatum { get; set; }
        public int AkteId { get; set; }
        public int PatientId { get; set; }
        public int? HausId { get; set; }
    }
}
