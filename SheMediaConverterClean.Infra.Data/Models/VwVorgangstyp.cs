using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwVorgangstyp
    {
        public VwVorgangstyp()
        {
            VwVorgang = new HashSet<VwVorgang>();
            VwVorgangstypdetail = new HashSet<VwVorgangstypdetail>();
        }

        public int VorgangstypId { get; set; }
        public string Bezeichnung { get; set; }
        public int? Bearbeitungszeit { get; set; }
        public int? Mahnstufe1 { get; set; }
        public int? Mahnstufe2 { get; set; }
        public int VorgangsbereichId { get; set; }
        public int? VorgangsId { get; set; }
        public int? OriginalVorgangstypdetailId { get; set; }
        public int? Position { get; set; }

        public virtual VwVorgangsbereich Vorgangsbereich { get; set; }
        public virtual ICollection<VwVorgang> VwVorgang { get; set; }
        public virtual ICollection<VwVorgangstypdetail> VwVorgangstypdetail { get; set; }
    }
}
