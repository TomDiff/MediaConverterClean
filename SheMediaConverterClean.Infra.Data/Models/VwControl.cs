using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwControl
    {
        public VwControl()
        {
            VwControlItem = new HashSet<VwControlItem>();
            VwVorgangControlItem = new HashSet<VwVorgangControlItem>();
        }

        public int Id { get; set; }
        public string ControlName { get; set; }
        public string Beschreibung { get; set; }

        public virtual ICollection<VwControlItem> VwControlItem { get; set; }
        public virtual ICollection<VwVorgangControlItem> VwVorgangControlItem { get; set; }
    }
}
