using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysErledigunsart
    {
        public SysErledigunsart()
        {
            ArcAktenTransaktion = new HashSet<ArcAktenTransaktion>();
            AusAusleihstatus = new HashSet<AusAusleihstatus>();
        }

        public int ErledigunsartId { get; set; }
        public string Bezeichnung { get; set; }
        public int EreignisTypId { get; set; }

        public virtual SysEreignisTyp EreignisTyp { get; set; }
        public virtual ICollection<ArcAktenTransaktion> ArcAktenTransaktion { get; set; }
        public virtual ICollection<AusAusleihstatus> AusAusleihstatus { get; set; }
    }
}
