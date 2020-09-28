using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcVerarbeitungsStatus
    {
        public ArcVerarbeitungsStatus()
        {
            ArcAkte = new HashSet<ArcAkte>();
            ArcAktenTransaktion = new HashSet<ArcAktenTransaktion>();
        }

        public int VerarbeitungsStatusId { get; set; }
        public string Bezeichnung { get; set; }

        public virtual ICollection<ArcAkte> ArcAkte { get; set; }
        public virtual ICollection<ArcAktenTransaktion> ArcAktenTransaktion { get; set; }
    }
}
