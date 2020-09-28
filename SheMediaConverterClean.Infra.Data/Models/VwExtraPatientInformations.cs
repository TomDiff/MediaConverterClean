using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwExtraPatientInformations
    {
        public int Id { get; set; }
        public string Hl7Typ { get; set; }
        public DateTime? Hl7Erstellungsdatum { get; set; }
        public string PatientId { get; set; }
        public string Fallnummer { get; set; }
        public DateTime? Erfassungsdatum { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public string Titel { get; set; }
        public string Geburtsdatum { get; set; }
        public string Geschlecht { get; set; }
        public string Patientenstatus { get; set; }
        public string Station { get; set; }
        public string Fachbateilung { get; set; }
        public string BehandelnderArzt { get; set; }
        public string AufnahmeDatum { get; set; }
        public string EntlassungsDatum { get; set; }
        public string Hl7Message { get; set; }
    }
}
