using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAktenhistorieErweitert
    {
        public string Aufenthaltsnummer { get; set; }
        public string PatientName { get; set; }
        public string PatientVorname { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
        public string BenutzerName { get; set; }
        public DateTime? EreignisTag { get; set; }
        public DateTime? EreignisDatum { get; set; }
        public string EreignisTyp { get; set; }
        public string EreignisGrund { get; set; }
        public string Anmerkung { get; set; }
        public string Aktennummer { get; set; }
        public string PapieraktenStatus { get; set; }
        public string FreigabeStatus { get; set; }
        public string MitarbeiterNachname { get; set; }
        public string MitarbeiterVorname { get; set; }
        public string ArchivBezeichnung { get; set; }
        public string LagerGang { get; set; }
        public string LagerRegal { get; set; }
        public string LagerEbene { get; set; }
        public string LagerFach { get; set; }
        public DateTime? Faelligkeitsdatum { get; set; }
        public string Verarbeitungsstatus { get; set; }
        public int? Mahnstufe { get; set; }
        public int? AkteId { get; set; }
        public int Aktenbewegung { get; set; }
    }
}
