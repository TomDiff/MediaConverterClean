using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VRegister
    {
        public int RegisterId { get; set; }
        public string Ordnungsziffer { get; set; }
        public string Register { get; set; }
        public bool? Aktiv { get; set; }
        public int? Sortierung { get; set; }
    }
}
