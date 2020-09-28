using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcElektronischerStatus
    {
        public ArcElektronischerStatus()
        {
            ArcAkte = new HashSet<ArcAkte>();
        }

        public int ElektonischerStatusId { get; set; }
        public string Bezeichnung { get; set; }

        public virtual ICollection<ArcAkte> ArcAkte { get; set; }
    }
}
