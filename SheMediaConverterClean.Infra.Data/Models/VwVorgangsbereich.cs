using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwVorgangsbereich
    {
        public VwVorgangsbereich()
        {
            VwVorgangstyp = new HashSet<VwVorgangstyp>();
        }

        public int VorgangsbereichId { get; set; }
        public string Bezeichnung { get; set; }
        public int? Position { get; set; }

        public virtual ICollection<VwVorgangstyp> VwVorgangstyp { get; set; }
    }
}
