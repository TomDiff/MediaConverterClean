using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwVorgangControlItem
    {
        public int Id { get; set; }
        public int VorgangId { get; set; }
        public int ControlId { get; set; }
        public int ControlItemId { get; set; }

        public virtual VwControl Control { get; set; }
        public virtual VwControlItem ControlItem { get; set; }
        public virtual VwVorgang Vorgang { get; set; }
    }
}
