﻿using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynMdmAvailabilityStatus
    {
        public DynMdmAvailabilityStatus()
        {
            DynBeleg = new HashSet<DynBeleg>();
        }

        public int Id { get; set; }
        public string ShortValue { get; set; }
        public string LongValue { get; set; }

        public virtual ICollection<DynBeleg> DynBeleg { get; set; }
    }
}
