using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VLieferungen
    {
        public int Rang { get; set; }
        public int? MittlererPapieraktenstatus { get; set; }
        public int PaketId { get; set; }
        public int? ArchivId { get; set; }
        public string PaketNummer { get; set; }
        public int LieferungId { get; set; }
        public DateTime? Lieferdatum { get; set; }
        public string Tbstatus { get; set; }
        public int? HausId { get; set; }
    }
}
