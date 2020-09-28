using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VSysBelegEbene
    {
        public string Bezeichnung { get; set; }
        public int BelegId { get; set; }
        public int BelegTypId { get; set; }
        public int? AktenaufenthaltId { get; set; }
        public int? RegisterId { get; set; }
        public string Ablagepfad { get; set; }
    }
}
