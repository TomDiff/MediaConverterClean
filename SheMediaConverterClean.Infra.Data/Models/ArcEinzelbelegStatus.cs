using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcEinzelbelegStatus
    {
        public ArcEinzelbelegStatus()
        {
            ArcAkte = new HashSet<ArcAkte>();
        }

        public int EinzelbelegStatusId { get; set; }
        public string Bezeichnung { get; set; }

        public virtual ICollection<ArcAkte> ArcAkte { get; set; }
    }
}
