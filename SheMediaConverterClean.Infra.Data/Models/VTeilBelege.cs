using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VTeilBelege
    {
        public int? LfdNr { get; set; }
        public string PapieraktenStatus { get; set; }
        public string Notiz { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public string AufenthaltNr { get; set; }
        public int? TeilBelegId { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public int? AkteId { get; set; }
        public int? PapieraktenStatusId { get; set; }
        public string BarcodeId { get; set; }
        public int? HausId { get; set; }
        public string BelegTyp { get; set; }
    }
}
