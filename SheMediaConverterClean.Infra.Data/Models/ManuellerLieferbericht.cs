using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ManuellerLieferbericht
    {
        public int LieferungId { get; set; }
        public string Aktennummer { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public string AufenthaltNr { get; set; }
        public string Bezeichnung { get; set; }
        public string Expr1 { get; set; }
        public string PatientenNr { get; set; }
        public string Nachname { get; set; }
        public string Vorname { get; set; }
        public DateTime? Geburtsdatum { get; set; }
        public string Geburtsname { get; set; }
    }
}
