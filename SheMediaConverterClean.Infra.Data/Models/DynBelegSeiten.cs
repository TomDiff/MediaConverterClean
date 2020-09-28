using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynBelegSeiten
    {
        public int BelegSeitenId { get; set; }
        public int BelegId { get; set; }
        public bool Anzeigen { get; set; }
        public int? Position { get; set; }
        public string Ablage { get; set; }
        public DateTime Erfassung { get; set; }
        public string Benutzer { get; set; }

        public virtual DynBeleg Beleg { get; set; }
    }
}
