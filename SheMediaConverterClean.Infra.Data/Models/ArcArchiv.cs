using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcArchiv
    {
        public ArcArchiv()
        {
            ArcLagerOrt = new HashSet<ArcLagerOrt>();
            LiePaket = new HashSet<LiePaket>();
        }

        public int ArchivId { get; set; }
        public string Bezeichnung { get; set; }
        public bool? IstArchiv { get; set; }
        public int? AbteilungId { get; set; }
        public bool? Aktiv { get; set; }
        public Guid? ArchivGuid { get; set; }
        public int? HausId { get; set; }

        public virtual DynStation Abteilung { get; set; }
        public virtual DynHaus Haus { get; set; }
        public virtual ICollection<ArcLagerOrt> ArcLagerOrt { get; set; }
        public virtual ICollection<LiePaket> LiePaket { get; set; }
    }
}
