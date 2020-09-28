using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAufenthaltEbene
    {
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public int? AkteId { get; set; }
        public string AufenthaltNr { get; set; }
        public int AufenthaltId { get; set; }
        public string Station { get; set; }
        public string Fachabteilung { get; set; }
        public string Haus { get; set; }
        public string Aufenthaltstyp { get; set; }
        public int? StationId { get; set; }
        public int? FachabteilungId { get; set; }
        public int? HausId { get; set; }
        public int? AufenthaltsTypId { get; set; }
        public int AktenaufenthaltId { get; set; }
        public int? PatientId { get; set; }
    }
}
