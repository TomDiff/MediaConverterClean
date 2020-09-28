using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynStation
    {
        public DynStation()
        {
            ArcAktenaufenthalt = new HashSet<ArcAktenaufenthalt>();
            ArcArchiv = new HashSet<ArcArchiv>();
        }

        public int StationId { get; set; }
        public string Bezeichnung { get; set; }
        public bool? Aktiv { get; set; }
        public int? Kisid { get; set; }
        public string KurzBezeichnung { get; set; }
        public int? HausId { get; set; }
        public int? FachabteilungId { get; set; }

        public virtual DynFachabteilung Fachabteilung { get; set; }
        public virtual ICollection<ArcAktenaufenthalt> ArcAktenaufenthalt { get; set; }
        public virtual ICollection<ArcArchiv> ArcArchiv { get; set; }
    }
}
