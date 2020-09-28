using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VRptAktenbewegung
    {
        public string Aktennummer { get; set; }
        public string PatientName { get; set; }
        public string PatientVorname { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
        public string Aufenthaltsnummer { get; set; }
        public DateTime? EreignisTag { get; set; }
        public DateTime? EreignisDatum { get; set; }
        public string MitarbeiterNachname { get; set; }
        public string MitarbeiterVorname { get; set; }
        public string EreignisTyp { get; set; }
        public string EreignisGrund { get; set; }
        public string Anmerkung { get; set; }
        public string PapieraktenStatus { get; set; }
        public string Freigabestatus { get; set; }
        public string Verarbeitungsstatus { get; set; }
    }
}
