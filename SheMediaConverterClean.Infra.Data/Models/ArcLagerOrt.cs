using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcLagerOrt
    {
        public ArcLagerOrt()
        {
            ArcAkte = new HashSet<ArcAkte>();
            AusAusleihstatus = new HashSet<AusAusleihstatus>();
        }

        public int LagerOrtId { get; set; }
        public string Bezeichnung { get; set; }
        public int? ArchivId { get; set; }
        public string Gang { get; set; }
        public string Regal { get; set; }
        public string Ebene { get; set; }
        public string Fach { get; set; }

        public virtual ArcArchiv Archiv { get; set; }
        public virtual ICollection<ArcAkte> ArcAkte { get; set; }
        public virtual ICollection<AusAusleihstatus> AusAusleihstatus { get; set; }
    }
}
