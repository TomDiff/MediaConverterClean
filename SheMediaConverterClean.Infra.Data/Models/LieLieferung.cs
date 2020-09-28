using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class LieLieferung
    {
        public LieLieferung()
        {
            LiePaket = new HashSet<LiePaket>();
        }

        public int LieferungId { get; set; }
        public DateTime? LieferungDatum { get; set; }
        public int? HausId { get; set; }

        public virtual DynHaus Haus { get; set; }
        public virtual ICollection<LiePaket> LiePaket { get; set; }
    }
}
