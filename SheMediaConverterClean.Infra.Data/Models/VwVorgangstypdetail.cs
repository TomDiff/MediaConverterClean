using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwVorgangstypdetail
    {
        public VwVorgangstypdetail()
        {
            VwAktivitaet = new HashSet<VwAktivitaet>();
        }

        public int VorgangstypdetailId { get; set; }
        public string Bezeichnung { get; set; }
        public string XmlMapping { get; set; }
        public int? Position { get; set; }
        public int? VorgangstypId { get; set; }
        public bool? AllowExport { get; set; }
        public bool? Ausgewaehlt { get; set; }

        public virtual VwVorgangstyp Vorgangstyp { get; set; }
        public virtual ICollection<VwAktivitaet> VwAktivitaet { get; set; }
    }
}
