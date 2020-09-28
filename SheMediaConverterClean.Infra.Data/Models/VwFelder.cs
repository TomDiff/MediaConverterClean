using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwFelder
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public string Eigenschaft { get; set; }
        public bool InPdfExportieren { get; set; }
        public bool Sichtbar { get; set; }
    }
}
