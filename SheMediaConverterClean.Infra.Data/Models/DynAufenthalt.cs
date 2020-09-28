using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynAufenthalt
    {
        public DynAufenthalt()
        {
            ArcAktenaufenthalt = new HashSet<ArcAktenaufenthalt>();
        }

        public int AufenthaltId { get; set; }
        public int? PatientId { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public string Notiz { get; set; }
        public string AufenthaltNr { get; set; }
        public int? HausId { get; set; }
        public DateTime? SperrDatum { get; set; }
        public DateTime? AufnahmedatumD { get; set; }
        public DateTime? EntlassungsdatumD { get; set; }
        public int? KorrekturEl { get; set; }

        public virtual DynHaus Haus { get; set; }
        public virtual DynPatient Patient { get; set; }
        public virtual ICollection<ArcAktenaufenthalt> ArcAktenaufenthalt { get; set; }
    }
}
