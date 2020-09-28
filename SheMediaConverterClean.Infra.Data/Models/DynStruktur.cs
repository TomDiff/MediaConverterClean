using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynStruktur
    {
        public int StrukturId { get; set; }
        public string Bezeichnung { get; set; }
        public int? OberStrukturId { get; set; }
        public int? Position { get; set; }
        public int? BaumId { get; set; }
        public string Anmerkung { get; set; }
    }
}
