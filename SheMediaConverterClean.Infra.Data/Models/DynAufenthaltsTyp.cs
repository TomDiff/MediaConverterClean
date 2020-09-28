using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynAufenthaltsTyp
    {
        public DynAufenthaltsTyp()
        {
            ArcAktenaufenthalt = new HashSet<ArcAktenaufenthalt>();
        }

        public int AufenthaltsTypId { get; set; }
        public string KurzBezeichnung { get; set; }
        public string Bezeichnung { get; set; }
        public string Hl7name { get; set; }
        public bool? IstAmbulant { get; set; }

        public virtual ICollection<ArcAktenaufenthalt> ArcAktenaufenthalt { get; set; }
    }
}
