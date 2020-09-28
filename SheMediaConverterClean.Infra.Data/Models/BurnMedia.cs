using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class BurnMedia
    {
        public int BurnMediaId { get; set; }
        public string DiscSize { get; set; }
        public string Name { get; set; }
    }
}
