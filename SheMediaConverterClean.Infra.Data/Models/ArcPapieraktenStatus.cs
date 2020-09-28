using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcPapieraktenStatus
    {
        public ArcPapieraktenStatus()
        {
            ArcAkte = new HashSet<ArcAkte>();
            ArcAktenTransaktion = new HashSet<ArcAktenTransaktion>();
            DynTeilBeleg = new HashSet<DynTeilBeleg>();
        }

        public int PapieraktenStatusId { get; set; }
        public string Bezeichnung { get; set; }
        public bool VerlegungErlaubt { get; set; }

        public virtual ICollection<ArcAkte> ArcAkte { get; set; }
        public virtual ICollection<ArcAktenTransaktion> ArcAktenTransaktion { get; set; }
        public virtual ICollection<DynTeilBeleg> DynTeilBeleg { get; set; }
    }
}
