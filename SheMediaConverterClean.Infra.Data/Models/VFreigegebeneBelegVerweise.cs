using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VFreigegebeneBelegVerweise
    {
        public int BelegId { get; set; }
        public int? AktenaufenthaltId { get; set; }
        public DateTime? Erfassungsdatum { get; set; }
        public int? ErfassungsMitarbeiterId { get; set; }
        public int? BelegTypId { get; set; }
        public int? BelegFormatId { get; set; }
        public int? PapierAktenStatusId { get; set; }
        public string Notiz { get; set; }
        public string Referenz { get; set; }
        public int? Seiten { get; set; }
        public string Ablagecode { get; set; }
        public string AblagecodeRollfilm { get; set; }
        public string AblagecodeDigital { get; set; }
        public int? SignaturNr { get; set; }
        public int? OberBelegId { get; set; }
        public string Bezeichnung { get; set; }
        public int? BesitzMitarbeiterId { get; set; }
        public string OcrText { get; set; }
        public byte[] Bild { get; set; }
        public int? Sortierung { get; set; }
        public Guid VerweisGuid { get; set; }
        public Guid BelegGuid { get; set; }
        public int? BenutzerId { get; set; }
        public int BelegVerweisBenutzer { get; set; }
    }
}
