﻿using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynStandort
    {
        public DynStandort()
        {
            DynFachabteilung = new HashSet<DynFachabteilung>();
        }

        public int StandortId { get; set; }
        public string Bezeichnung { get; set; }
        public string KurzBezeichnung { get; set; }

        public virtual ICollection<DynFachabteilung> DynFachabteilung { get; set; }
    }
}
