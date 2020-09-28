using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwBearbeitungsstatus
    {
        public VwBearbeitungsstatus()
        {
            VwAktivitaet = new HashSet<VwAktivitaet>();
            VwVorgang = new HashSet<VwVorgang>();
            VwVorgangsdetail = new HashSet<VwVorgangsdetail>();
        }

        public int BearbeitungsstatusId { get; set; }
        public string Bezeichnung { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VwAktivitaet> VwAktivitaet { get; set; }
        public virtual ICollection<VwVorgang> VwVorgang { get; set; }
        public virtual ICollection<VwVorgangsdetail> VwVorgangsdetail { get; set; }
    }
}
