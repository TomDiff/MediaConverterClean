using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynPatient
    {
        public DynPatient()
        {
            DynAufenthalt = new HashSet<DynAufenthalt>();
        }

        public int PatientId { get; set; }
        public string PatientenNr { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Geburtsname { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public bool? Verstorben { get; set; }
        public int? HausId { get; set; }
        public string Geschlecht { get; set; }
        public string Strasse { get; set; }
        public string Zusatz { get; set; }
        public string Ort { get; set; }
        public string Bundesland { get; set; }
        public string Plz { get; set; }
        public string Land { get; set; }

        public virtual ICollection<DynAufenthalt> DynAufenthalt { get; set; }
    }
}
