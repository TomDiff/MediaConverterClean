using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwBelegverweis
    {
        public int BelegverweisId { get; set; }
        public string Bezeichnung { get; set; }
        public byte[] Bild { get; set; }
        public int? Position { get; set; }
        public int? AktivitaetId { get; set; }
        public string Belegtyp { get; set; }
        public int? BelegId { get; set; }
        public string BildName { get; set; }
        public string AblagePfad { get; set; }
        public string LastModificationUser { get; set; }
        public DateTime? CreatedTime { get; set; }

        public virtual VwAktivitaet Aktivitaet { get; set; }
    }
}
