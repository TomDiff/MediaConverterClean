using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class GpBelegVerweis
    {
        public int BelegVerweisId { get; set; }
        public int? Verweis { get; set; }
        public int BenutzerId { get; set; }
        public int? EbeneId { get; set; }
        public Guid BelegGuid { get; set; }
        public Guid? VerweisGuid { get; set; }

        public virtual SysBenutzer Benutzer { get; set; }
    }
}
