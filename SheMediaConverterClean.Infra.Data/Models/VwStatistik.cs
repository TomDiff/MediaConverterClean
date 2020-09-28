using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwStatistik
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? MultiSelect { get; set; }
    }
}
