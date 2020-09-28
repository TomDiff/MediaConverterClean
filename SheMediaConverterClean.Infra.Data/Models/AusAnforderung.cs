using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class AusAnforderung
    {
        public int AnforderungId { get; set; }
        public int? AkteId { get; set; }
        public int? MitarbeiterId { get; set; }
        public int? AusleihEreignisgrundId { get; set; }
        public DateTime? AnforderungsDatum { get; set; }
        public string AnfordererNameKlartext { get; set; }
        public int? AnfordererId { get; set; }

        public virtual ArcAkte Akte { get; set; }
        public virtual SysEreignisgrund AusleihEreignisgrund { get; set; }
    }
}
