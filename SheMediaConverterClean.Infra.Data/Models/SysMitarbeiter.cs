using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysMitarbeiter
    {
        public SysMitarbeiter()
        {
            ArcAktenTransaktion = new HashSet<ArcAktenTransaktion>();
            AusAusleihstatusAngefordertDurch = new HashSet<AusAusleihstatus>();
            AusAusleihstatusEmpfangendurchDurch = new HashSet<AusAusleihstatus>();
            SysBenutzer = new HashSet<SysBenutzer>();
        }

        public int MitarbeiterId { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Strasse { get; set; }
        public string Postleitzahl { get; set; }
        public string Wohnort { get; set; }
        public int? KisId { get; set; }
        public bool? Aktiv { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public string MitarbeiterNummer { get; set; }
        public string EmailAdresse { get; set; }
        public string Titel { get; set; }
        public int? HausId { get; set; }

        public virtual ICollection<ArcAktenTransaktion> ArcAktenTransaktion { get; set; }
        public virtual ICollection<AusAusleihstatus> AusAusleihstatusAngefordertDurch { get; set; }
        public virtual ICollection<AusAusleihstatus> AusAusleihstatusEmpfangendurchDurch { get; set; }
        public virtual ICollection<SysBenutzer> SysBenutzer { get; set; }
    }
}
