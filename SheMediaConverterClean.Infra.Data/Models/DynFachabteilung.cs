using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynFachabteilung
    {
        public DynFachabteilung()
        {
            ArcAktenaufenthalt = new HashSet<ArcAktenaufenthalt>();
            DynAusleiheUserFachabteilung = new HashSet<DynAusleiheUserFachabteilung>();
            DynStation = new HashSet<DynStation>();
        }

        public int FachabteilungId { get; set; }
        public string Bezeichnung { get; set; }
        public bool? Aktiv { get; set; }
        public int? Kisid { get; set; }
        public string KurzBezeichnung { get; set; }
        public int? HausId { get; set; }
        public int? StandortId { get; set; }

        public virtual DynHaus Haus { get; set; }
        public virtual DynStandort Standort { get; set; }
        public virtual ICollection<ArcAktenaufenthalt> ArcAktenaufenthalt { get; set; }
        public virtual ICollection<DynAusleiheUserFachabteilung> DynAusleiheUserFachabteilung { get; set; }
        public virtual ICollection<DynStation> DynStation { get; set; }
    }
}
