using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysMahnstufe
    {
        public SysMahnstufe()
        {
            ArcAkte = new HashSet<ArcAkte>();
            ArcAktenTransaktion = new HashSet<ArcAktenTransaktion>();
            AusAusleihstatus = new HashSet<AusAusleihstatus>();
        }

        public int MahnStufeId { get; set; }
        public int EreignisTypId { get; set; }
        public int? Stufe { get; set; }
        public string Text { get; set; }
        public byte? AnzahlTage { get; set; }

        public virtual SysEreignisTyp EreignisTyp { get; set; }
        public virtual ICollection<ArcAkte> ArcAkte { get; set; }
        public virtual ICollection<ArcAktenTransaktion> ArcAktenTransaktion { get; set; }
        public virtual ICollection<AusAusleihstatus> AusAusleihstatus { get; set; }
    }
}
