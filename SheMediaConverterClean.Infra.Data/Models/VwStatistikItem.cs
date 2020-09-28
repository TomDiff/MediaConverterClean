using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwStatistikItem
    {
        public int Id { get; set; }
        public int StatistikId { get; set; }
        public string ItemName { get; set; }
    }
}
