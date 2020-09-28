using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VNeuePakete
    {
        public int PaketId { get; set; }
        public int LieferungId { get; set; }
        public string PaketNummer { get; set; }
        public DateTime? LieferungDatum { get; set; }
        public int? HausId { get; set; }
        public int? ArchivId { get; set; }
    }
}
