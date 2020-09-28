using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAlleVerweise
    {
        public int? Inhaber { get; set; }
        public Guid VerweisGuid { get; set; }
        public int? FuerBenutzer { get; set; }
        public Guid FuerBenutzerGuid { get; set; }
    }
}
