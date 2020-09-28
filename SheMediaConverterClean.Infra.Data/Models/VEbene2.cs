using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VEbene2
    {
        public int? PatientId { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public string AufenthaltNr { get; set; }
        public string Titel { get; set; }
        public int StationId { get; set; }
        public int? HausId { get; set; }
    }
}
