using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynArchive
    {
        public DynArchive()
        {
            DynBeleg = new HashSet<DynBeleg>();
        }

        public int ArchivId { get; set; }
        public string ArchivBezeichnung { get; set; }

        public virtual ICollection<DynBeleg> DynBeleg { get; set; }
    }
}
