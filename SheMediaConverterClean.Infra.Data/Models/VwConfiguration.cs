using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwConfiguration
    {
        public int ConfigurationId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string DisplayName { get; set; }
    }
}
