using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwEmailHistorie
    {
        public int EmailHistorieId { get; set; }
        public int VorgangId { get; set; }
        public DateTime? EmailDatum { get; set; }
        public int? UserId { get; set; }
        public string Adressen { get; set; }
        public string Kommentar { get; set; }
        public string Kommentarfarbe { get; set; }

        public virtual VwVorgang Vorgang { get; set; }
    }
}
