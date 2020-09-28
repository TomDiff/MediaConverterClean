using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwAktivitaet
    {
        public VwAktivitaet()
        {
            VwBelegverweis = new HashSet<VwBelegverweis>();
        }

        public int AktivitaetId { get; set; }
        public string Text { get; set; }
        public DateTime? DatumAnlage { get; set; }
        public DateTime? DatumBezug { get; set; }
        public string Notiz { get; set; }
        public string BearbeiterAnlage { get; set; }
        public string BearbeiterDurchfuehrung { get; set; }
        public int AktionstypId { get; set; }
        public DateTime? DatumWiedervorlage { get; set; }
        public int? VorgangsdetailId { get; set; }
        public int? VorgangId { get; set; }
        public int BearbeitungsstatusId { get; set; }
        public string Ergebnis { get; set; }
        public int? VorgangstypdetailId { get; set; }
        public int? AktivitaetErledigungsstatusId { get; set; }
        public DateTime? EmailGesendet { get; set; }
        public string EmailGesendetVon { get; set; }
        public DateTime? ErledigtAm { get; set; }
        public int? Position { get; set; }
        public bool? AllowExport { get; set; }
        public bool? ShowImages { get; set; }
        public bool? Ausgewaehlt { get; set; }

        public virtual VwAktionstyp Aktionstyp { get; set; }
        public virtual VwAktivitaetErledigungsstatus AktivitaetErledigungsstatus { get; set; }
        public virtual VwBearbeitungsstatus Bearbeitungsstatus { get; set; }
        public virtual VwVorgang Vorgang { get; set; }
        public virtual VwVorgangsdetail Vorgangsdetail { get; set; }
        public virtual VwVorgangstypdetail Vorgangstypdetail { get; set; }
        public virtual ICollection<VwBelegverweis> VwBelegverweis { get; set; }
    }
}
