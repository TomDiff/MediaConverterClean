using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwControlItem
    {
        public VwControlItem()
        {
            VwVorgangControlItem = new HashSet<VwVorgangControlItem>();
        }

        public int Id { get; set; }
        public int ControlId { get; set; }
        public string ItemName { get; set; }

        public virtual VwControl Control { get; set; }
        public virtual ICollection<VwVorgangControlItem> VwVorgangControlItem { get; set; }
    }
}
