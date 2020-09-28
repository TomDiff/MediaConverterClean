using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysEreignisgrund
    {
        public SysEreignisgrund()
        {
            AusAnforderung = new HashSet<AusAnforderung>();
            AusAusleihstatus = new HashSet<AusAusleihstatus>();
        }

        public int EreignisgrundId { get; set; }
        public int? EreignisTypId { get; set; }
        public string Bezeichnung { get; set; }
        public string Notiz { get; set; }
        public bool? Aktiv { get; set; }

        public virtual SysEreignisTyp EreignisTyp { get; set; }
        public virtual ICollection<AusAnforderung> AusAnforderung { get; set; }
        public virtual ICollection<AusAusleihstatus> AusAusleihstatus { get; set; }
    }
}
