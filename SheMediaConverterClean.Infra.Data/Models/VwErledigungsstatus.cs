using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwErledigungsstatus
    {
        public VwErledigungsstatus()
        {
            VwVorgang = new HashSet<VwVorgang>();
        }

        public int ErledigungsstatusId { get; set; }
        public string Bezeichnung { get; set; }

        public virtual ICollection<VwVorgang> VwVorgang { get; set; }
    }
}
