using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcAktenaufenthaltStatus
    {
        public ArcAktenaufenthaltStatus()
        {
            ArcAktenaufenthalt = new HashSet<ArcAktenaufenthalt>();
        }

        public int AktenaufenthaltStatusId { get; set; }
        public string Bezeichnung { get; set; }

        public virtual ICollection<ArcAktenaufenthalt> ArcAktenaufenthalt { get; set; }
    }
}
