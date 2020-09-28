using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class PaketVerwaltung
    {
        public int PaketVerwaltungId { get; set; }
        public string LagerOrt { get; set; }
        public DateTime GebDatum { get; set; }
        public int PaketNr { get; set; }
        public int? FilmNr { get; set; }
        public int? BildNr { get; set; }
    }
}
