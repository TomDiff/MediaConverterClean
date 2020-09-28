using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwVorgangsdetail
    {
        public VwVorgangsdetail()
        {
            VwAktivitaet = new HashSet<VwAktivitaet>();
        }

        public int VorgangsdetailId { get; set; }
        public string Bezeichnung { get; set; }
        public string XmlMapping { get; set; }
        public int? Position { get; set; }
        public int? VorgangId { get; set; }
        public string Notiz { get; set; }
        public int? BearbeitungsstatusId { get; set; }
        public int? VorgangstypdetailId { get; set; }
        public DateTime? Datum { get; set; }
        public DateTime? Frist { get; set; }
        public string Ergebnis { get; set; }
        public bool? AllowExport { get; set; }

        public virtual VwBearbeitungsstatus Bearbeitungsstatus { get; set; }
        public virtual VwVorgang Vorgang { get; set; }
        public virtual ICollection<VwAktivitaet> VwAktivitaet { get; set; }
    }
}
