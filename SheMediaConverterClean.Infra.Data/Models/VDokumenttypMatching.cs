using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VDokumenttypMatching
    {
        public int DokumenttypMatchingId { get; set; }
        public string DokumenttypMatching { get; set; }
        public int? DokumenttypId { get; set; }
        public string Matching { get; set; }
        public string RegEx { get; set; }
        public bool? LikeMatching { get; set; }
        public bool? Aktiv { get; set; }
        public int? Sortierung { get; set; }
    }
}
