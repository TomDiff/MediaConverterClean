using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class LiePaket
    {
        public LiePaket()
        {
            LiePaketAkte = new HashSet<LiePaketAkte>();
        }

        public int PaketId { get; set; }
        public int LieferungId { get; set; }
        public string PaketNummer { get; set; }
        public int? ArchivId { get; set; }

        public virtual ArcArchiv Archiv { get; set; }
        public virtual LieLieferung Lieferung { get; set; }
        public virtual ICollection<LiePaketAkte> LiePaketAkte { get; set; }
    }
}
