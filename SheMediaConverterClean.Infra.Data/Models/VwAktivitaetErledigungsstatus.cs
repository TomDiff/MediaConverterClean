using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwAktivitaetErledigungsstatus
    {
        public VwAktivitaetErledigungsstatus()
        {
            VwAktivitaet = new HashSet<VwAktivitaet>();
        }

        public int AktivitaetErledigungsstatusId { get; set; }
        public string Bezeichnung { get; set; }

        public virtual ICollection<VwAktivitaet> VwAktivitaet { get; set; }
    }
}
