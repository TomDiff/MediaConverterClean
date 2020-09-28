using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcAktenaufenthalt
    {
        public ArcAktenaufenthalt()
        {
            DynBeleg = new HashSet<DynBeleg>();
            DynRegister = new HashSet<DynRegister>();
        }

        public int AktenaufenthaltId { get; set; }
        public int? AufenthaltId { get; set; }
        public int? FachabteilungId { get; set; }
        public int? StationId { get; set; }
        public int? AufenthaltsTypId { get; set; }
        public int AktenaufenthaltStatusId { get; set; }
        public int? SammelakteId { get; set; }
        public bool IstZusatzakte { get; set; }
        public int? AkteId { get; set; }
        public string Notiz { get; set; }

        public virtual ArcAkte Akte { get; set; }
        public virtual ArcAktenaufenthaltStatus AktenaufenthaltStatus { get; set; }
        public virtual DynAufenthalt Aufenthalt { get; set; }
        public virtual DynAufenthaltsTyp AufenthaltsTyp { get; set; }
        public virtual DynFachabteilung Fachabteilung { get; set; }
        public virtual ArcAkte Sammelakte { get; set; }
        public virtual DynStation Station { get; set; }
        public virtual ICollection<DynBeleg> DynBeleg { get; set; }
        public virtual ICollection<DynRegister> DynRegister { get; set; }
    }
}
