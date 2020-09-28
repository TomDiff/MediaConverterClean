using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class OcrQueuedImage
    {
        public int OcrQueueId { get; set; }
        public int BelegId { get; set; }
        public int Page { get; set; }
        public string ImagePath { get; set; }
        public DateTime? EnqueuedTime { get; set; }
        public DateTime? ProcessedTime { get; set; }

        public virtual DynBeleg Beleg { get; set; }
    }
}
