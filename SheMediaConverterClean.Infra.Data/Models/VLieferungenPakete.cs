using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VLieferungenPakete
    {
        public int? LieferungId { get; set; }
        public DateTime? LieferungDatum { get; set; }
        public int? HausId { get; set; }
        public int PaketId { get; set; }
        public string PaketNummer { get; set; }
        public int? ArchivId { get; set; }
    }
}
