using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynDokumenttypMatching
    {
        public int DokumenttypMatchingId { get; set; }
        public string Bezeichnung { get; set; }
        public string Matching { get; set; }
        public string RegEx { get; set; }
        public bool? LikeMatching { get; set; }
        public int? DokumenttypId { get; set; }
        public bool? Aktiv { get; set; }
        public int? Sortierung { get; set; }

        public virtual DynDokumenttyp Dokumenttyp { get; set; }
    }
}
