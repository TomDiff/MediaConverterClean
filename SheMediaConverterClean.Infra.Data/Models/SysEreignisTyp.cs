using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysEreignisTyp
    {
        public SysEreignisTyp()
        {
            ArcAkte = new HashSet<ArcAkte>();
            ArcAktenTransaktion = new HashSet<ArcAktenTransaktion>();
            AusAusleihstatus = new HashSet<AusAusleihstatus>();
            SysEreignisgrund = new HashSet<SysEreignisgrund>();
            SysErledigunsart = new HashSet<SysErledigunsart>();
            SysMahnstufe = new HashSet<SysMahnstufe>();
        }

        public int EreignisTypId { get; set; }
        public string Bezeichnung { get; set; }
        public string Notiz { get; set; }

        public virtual ICollection<ArcAkte> ArcAkte { get; set; }
        public virtual ICollection<ArcAktenTransaktion> ArcAktenTransaktion { get; set; }
        public virtual ICollection<AusAusleihstatus> AusAusleihstatus { get; set; }
        public virtual ICollection<SysEreignisgrund> SysEreignisgrund { get; set; }
        public virtual ICollection<SysErledigunsart> SysErledigunsart { get; set; }
        public virtual ICollection<SysMahnstufe> SysMahnstufe { get; set; }
    }
}
