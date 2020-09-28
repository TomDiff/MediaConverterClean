using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysBelegTyp
    {
        public SysBelegTyp()
        {
            DynBeleg = new HashSet<DynBeleg>();
            DynDokumenttyp = new HashSet<DynDokumenttyp>();
            DynTeilBeleg = new HashSet<DynTeilBeleg>();
            SysBelegTypBarcode = new HashSet<SysBelegTypBarcode>();
        }

        public int BelegTypId { get; set; }
        public string Bezeichnung { get; set; }
        public int? IconGeschlossenId { get; set; }
        public int? IconOffenId { get; set; }
        public int? IconAktivId { get; set; }
        public bool? Aktiv { get; set; }
        public int? Sortierung { get; set; }
        public string Barcode { get; set; }
        public bool? ShowDateOnBelegEbene { get; set; }
        public bool SendMdm { get; set; }
        public int? RegisterId { get; set; }
        public bool? AnzeigePatient { get; set; }
        public bool? AnzeigeAufenthalt { get; set; }

        public virtual DynRegister Register { get; set; }
        public virtual ICollection<DynBeleg> DynBeleg { get; set; }
        public virtual ICollection<DynDokumenttyp> DynDokumenttyp { get; set; }
        public virtual ICollection<DynTeilBeleg> DynTeilBeleg { get; set; }
        public virtual ICollection<SysBelegTypBarcode> SysBelegTypBarcode { get; set; }
    }
}
