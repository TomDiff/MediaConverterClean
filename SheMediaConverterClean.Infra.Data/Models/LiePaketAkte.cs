using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class LiePaketAkte
    {
        public int PaketAkteId { get; set; }
        public int PaketId { get; set; }
        public int AkteId { get; set; }
        public string Bemerkung { get; set; }
        public int? TeilBelegId { get; set; }

        public virtual ArcAkte Akte { get; set; }
        public virtual LiePaket Paket { get; set; }
    }
}
