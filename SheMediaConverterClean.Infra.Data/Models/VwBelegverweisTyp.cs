using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwBelegverweisTyp
    {
        public VwBelegverweisTyp()
        {
            VwBelegverweisVorgang = new HashSet<VwBelegverweisVorgang>();
        }

        public int BelegverweisTypId { get; set; }
        public string Beschreibung { get; set; }

        public virtual ICollection<VwBelegverweisVorgang> VwBelegverweisVorgang { get; set; }
    }
}
