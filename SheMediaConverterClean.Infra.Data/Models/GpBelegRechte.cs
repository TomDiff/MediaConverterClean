using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class GpBelegRechte
    {
        public Guid BelegGuid { get; set; }
        public int BenutzerId { get; set; }
        public byte C { get; set; }
        public byte R { get; set; }
        public byte U { get; set; }
        public byte D { get; set; }
        public int FuerBenutzerId { get; set; }

        public virtual SysBenutzer FuerBenutzer { get; set; }
    }
}
