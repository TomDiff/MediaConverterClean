using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VDokumenttyp
    {
        public int DokumenttypId { get; set; }
        public string Dokumenttyp { get; set; }
        public int? BelegtypId { get; set; }
        public bool? Aktiv { get; set; }
        public int? Sortierung { get; set; }
    }
}
