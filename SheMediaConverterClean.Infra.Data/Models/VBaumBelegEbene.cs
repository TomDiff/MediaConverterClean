using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VBaumBelegEbene
    {
        public int BelegId { get; set; }
        public string Title { get; set; }
        public string Ablagepfad { get; set; }
        public int? BelegtypId { get; set; }
        public string VersionId { get; set; }
        public int? AktenAufenthaltId { get; set; }
        public DateTime? Erfassungsdatum { get; set; }
        public string Dokumenttyp { get; set; }
        public string BelegTypBeschreibung { get; set; }
        public string BelegTypVollstaendigerName { get; set; }
        public int? DokumenttypId { get; set; }
    }
}
