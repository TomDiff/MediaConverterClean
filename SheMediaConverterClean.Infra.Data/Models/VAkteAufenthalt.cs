using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAkteAufenthalt
    {
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public int? PapieraktenStatus { get; set; }
        public int? FreigabeStatus { get; set; }
        public int? ElektronischerStatus { get; set; }
        public int? VerarbeitungsStatus { get; set; }
        public int? EinzelbelegStatus { get; set; }
        public string Aktennummer { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public DateTime? Eingangsdatum { get; set; }
        public int AkteId { get; set; }
        public int? MahnStufeId { get; set; }
        public int? LagerOrtId { get; set; }
        public int? PatientId { get; set; }
        public string Referenz { get; set; }
        public int? AufenthaltId { get; set; }
        public string AktenAnmerkung { get; set; }
        public int? AktenTypId { get; set; }
        public int? HausId { get; set; }
    }
}
