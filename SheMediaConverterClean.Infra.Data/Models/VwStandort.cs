using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwStandort
    {
        public VwStandort()
        {
            VwStandortUser = new HashSet<VwStandortUser>();
            VwVorgang = new HashSet<VwVorgang>();
        }

        public int StandortId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VwStandortUser> VwStandortUser { get; set; }
        public virtual ICollection<VwVorgang> VwVorgang { get; set; }
    }
}
