using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynAusleiheUserFachabteilung
    {
        public int AusleiheUserFachabteilungId { get; set; }
        public int? UserNumber { get; set; }
        public int? FachabteilungId { get; set; }
        public int? HausId { get; set; }

        public virtual DynFachabteilung Fachabteilung { get; set; }
        public virtual DynHaus Haus { get; set; }
    }
}
