using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynDokumenttyp
    {
        public DynDokumenttyp()
        {
            DynBeleg = new HashSet<DynBeleg>();
            DynDokumenttypMatching = new HashSet<DynDokumenttypMatching>();
        }

        public int DokumenttypId { get; set; }
        public string Bezeichnung { get; set; }
        public int? BelegtypId { get; set; }
        public bool? Aktiv { get; set; }
        public int? Sortierung { get; set; }

        public virtual SysBelegTyp Belegtyp { get; set; }
        public virtual ICollection<DynBeleg> DynBeleg { get; set; }
        public virtual ICollection<DynDokumenttypMatching> DynDokumenttypMatching { get; set; }
    }
}
