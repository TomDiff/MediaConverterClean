using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynHaus
    {
        public DynHaus()
        {
            ArcArchiv = new HashSet<ArcArchiv>();
            DynAufenthalt = new HashSet<DynAufenthalt>();
            DynAusleiheUserFachabteilung = new HashSet<DynAusleiheUserFachabteilung>();
            DynFachabteilung = new HashSet<DynFachabteilung>();
            LieLieferung = new HashSet<LieLieferung>();
        }

        public int HausId { get; set; }
        public string KurzBezeichnung { get; set; }
        public string Bezeichnung { get; set; }
        public string Hl7name { get; set; }
        public int? VerlegerStruktur { get; set; }

        public virtual ICollection<ArcArchiv> ArcArchiv { get; set; }
        public virtual ICollection<DynAufenthalt> DynAufenthalt { get; set; }
        public virtual ICollection<DynAusleiheUserFachabteilung> DynAusleiheUserFachabteilung { get; set; }
        public virtual ICollection<DynFachabteilung> DynFachabteilung { get; set; }
        public virtual ICollection<LieLieferung> LieLieferung { get; set; }
    }
}
