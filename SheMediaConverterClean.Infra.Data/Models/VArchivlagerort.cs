using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VArchivlagerort
    {
        public int ArchivId { get; set; }
        public string Bezeichnung { get; set; }
        public Guid? ArchivGuid { get; set; }
        public int? HausId { get; set; }
    }
}
