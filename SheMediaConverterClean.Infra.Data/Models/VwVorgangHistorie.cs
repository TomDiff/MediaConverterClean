using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwVorgangHistorie
    {
        public int Id { get; set; }
        public int VorgangId { get; set; }
        public DateTime? Datum { get; set; }
        public string Message { get; set; }
        public string MessageFarbe { get; set; }

        public virtual VwVorgang Vorgang { get; set; }
    }
}
