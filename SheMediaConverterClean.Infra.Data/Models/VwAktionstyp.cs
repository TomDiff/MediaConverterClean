using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwAktionstyp
    {
        public VwAktionstyp()
        {
            VwAktivitaet = new HashSet<VwAktivitaet>();
        }

        public int AktionstypId { get; set; }
        public string Bezeichnung { get; set; }

        public virtual ICollection<VwAktivitaet> VwAktivitaet { get; set; }
    }
}
