using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VBelegEbene
    {
        public int Index0 { get; set; }
        public int BelegId { get; set; }
        public DateTime? Erfassungsdatum { get; set; }
        public string Ablagepfad { get; set; }
        public int? BelegTypId { get; set; }
        public int Beleg { get; set; }
        public string BelegTypName { get; set; }
        public string BelegTypBeschreibung { get; set; }
        public int? Sicht { get; set; }
        public int? Druck { get; set; }
        public string BelegTypVollstaendigerName { get; set; }
        public string Bezeichnung { get; set; }
        public int? Seiten { get; set; }
        public string NameToDisplay { get; set; }
        public int? PatientId { get; set; }
        public bool? AnzeigePatient { get; set; }
    }
}
