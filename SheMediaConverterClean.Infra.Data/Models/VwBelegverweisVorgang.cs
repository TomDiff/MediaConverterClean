using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwBelegverweisVorgang
    {
        public int BelegverweisVorgangId { get; set; }
        public string Bezeichnung { get; set; }
        public int? Position { get; set; }
        public string Bildname { get; set; }
        public string AblagePfad { get; set; }
        public string LastModificationUser { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? VorgangId { get; set; }
        public int? BelegverweisTypId { get; set; }

        public virtual VwBelegverweisTyp BelegverweisTyp { get; set; }
    }
}
