using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAktenTyp
    {
        public int AktenTypId { get; set; }
        public string Bezeichnung { get; set; }
        public bool? Editierbar { get; set; }
        public bool? Digitalisierbar { get; set; }
        public int? Sortierung { get; set; }
    }
}
