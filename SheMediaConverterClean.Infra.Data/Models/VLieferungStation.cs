﻿using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VLieferungStation
    {
        public string HausKurzBezeichnung { get; set; }
        public string AufenthaltsTypKurzBezeichnung { get; set; }
        public string StationBezeichnung { get; set; }
        public string FachabteilungBezeichnung { get; set; }
        public string StationKurzBezeichnung { get; set; }
        public string FachabteilungKurzBezeichnung { get; set; }
        public int? LfdNr { get; set; }
        public string TeilBelegBezeichnung { get; set; }
        public int TeilBelegPapieraktenStatus { get; set; }
        public string PaketNummer { get; set; }
        public string LagerortBezeichnung { get; set; }
        public DateTime? Eingangsdatum { get; set; }
        public DateTime? Lieferdatum { get; set; }
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
        public string AkteVerpackenBemerkung { get; set; }
        public int? PaketId { get; set; }
        public int? LieferungId { get; set; }
        public int? PatientId { get; set; }
        public int? AufenthaltId { get; set; }
        public string Bezeichnung { get; set; }
        public bool? Editierbar { get; set; }
        public bool? Digitalisierbar { get; set; }
        public int? TeilBelegId { get; set; }
        public string BarcodeId { get; set; }
        public int? Station { get; set; }
        public int? AufenthaltsTyp { get; set; }
        public string AufenthaltsTypBezeichnung { get; set; }
        public int? HausId { get; set; }
        public string AktenAnmerkung { get; set; }
        public int? AktenaufenthaltId { get; set; }
    }
}
