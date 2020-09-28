using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysIcon
    {
        public int IconId { get; set; }
        public string Bezeichnung { get; set; }
        public byte[] Klein { get; set; }
        public byte[] Mittel { get; set; }
        public byte[] Groß { get; set; }
    }
}
