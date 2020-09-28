using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class OcrResult
    {
        public int OcrResultId { get; set; }
        public int BelegId { get; set; }
        public int Page { get; set; }
        public DateTime? OcrTime { get; set; }
        public string OcrText { get; set; }

        public virtual DynBeleg Beleg { get; set; }
    }
}
