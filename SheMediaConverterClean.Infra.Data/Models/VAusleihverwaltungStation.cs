using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAusleihverwaltungStation
    {
        public string HausKurzBezeichnung { get; set; }
        public string AufenthaltsTypKurzBezeichnung { get; set; }
        public int? MahnTage { get; set; }
        public string StationBezeichnung { get; set; }
        public string FachabteilungBezeichnung { get; set; }
        public string PatientNachname { get; set; }
        public string PatientVorname { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
        public string PatientGeburtsname { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public int? PapieraktenStatus { get; set; }
        public int? FreigabeStatus { get; set; }
        public int? ElektronischerStatus { get; set; }
        public int? VerarbeitungsStatus { get; set; }
        public int? EinzelbelegStatus { get; set; }
        public string Aktennummer { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public string Patientennummer { get; set; }
        public int AkteId { get; set; }
        public string EntleiherNachname { get; set; }
        public string EntleiherVorname { get; set; }
        public string LagerortBezeichnung { get; set; }
        public DateTime? Ausleihdatum { get; set; }
        public DateTime? Faelligkeitsdatum { get; set; }
        public int? RueckgabeMahnstufe { get; set; }
        public byte? AnzahlVerlaengerungen { get; set; }
        public string Ausleihgrund { get; set; }
        public DateTime? Eingangsdatum { get; set; }
        public int AufenthaltId { get; set; }
        public int PatientId { get; set; }
        public string AusleihAnmerkung { get; set; }
        public string PatientGeburtsdatumText { get; set; }
        public int? EreignisTypId { get; set; }
        public int? Station { get; set; }
        public string AktenAnmerkung { get; set; }
        public int? Fachabteilung { get; set; }
        public int? HausId { get; set; }
        public int? AufenthaltsTyp { get; set; }
        public string AufenthaltsTypBezeichnung { get; set; }
        public int AktenaufenthaltId { get; set; }
    }
}
