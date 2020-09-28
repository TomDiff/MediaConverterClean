using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VLieferungAusdruck
    {
        public string HausKurzBezeichnung { get; set; }
        public string AufenthaltsTyp { get; set; }
        public string StationBezeichnung { get; set; }
        public string FachabteilungBezeichnung { get; set; }
        public string StationKurzBezeichnung { get; set; }
        public string FachabteilungKurzBezeichnung { get; set; }
        public int? LfdNr { get; set; }
        public string TeilBelegBezeichnung { get; set; }
        public int? TeilBelegPapieraktenStatus { get; set; }
        public string Aktennummer { get; set; }
        public string Patientennummer { get; set; }
        public string PatientVorname { get; set; }
        public string PatientNachname { get; set; }
        public string PatientGeburtsname { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public string PaketNummer { get; set; }
        public string AkteVerpackenBemerkung { get; set; }
        public int AkteId { get; set; }
        public int PaketId { get; set; }
        public DateTime? Lieferdatum { get; set; }
        public int? FreigabeStatus { get; set; }
        public string BarcodeId { get; set; }
        public int? HausId { get; set; }
        public int? PapieraktenStatus { get; set; }
    }
}
