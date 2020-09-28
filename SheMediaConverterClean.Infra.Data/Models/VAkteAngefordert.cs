using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAkteAngefordert
    {
        public string AnfordererName { get; set; }
        public DateTime? AnforderungsDatum { get; set; }
        public string Ausleihgrund { get; set; }
        public string Aktennummer { get; set; }
        public string Patientennummer { get; set; }
        public string PatientNachname { get; set; }
        public string PatientVorname { get; set; }
        public string PatientGeburtsname { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
        public int? ElektronischerStatus { get; set; }
        public int? PapieraktenStatus { get; set; }
        public int? FreigabeStatus { get; set; }
        public int? VerarbeitungsStatus { get; set; }
        public int? AkteId { get; set; }
        public int? MitarbeiterId { get; set; }
        public int AnforderungId { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public string ArchivBezeichnung { get; set; }
        public string LagerGang { get; set; }
        public string LagerRegal { get; set; }
        public string LagerEbene { get; set; }
        public string LagerFach { get; set; }
        public int? AusleihgrundId { get; set; }
        public int? EinzelbelegStatusId { get; set; }
        public int? HausId { get; set; }
    }
}
