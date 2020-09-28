using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VLieferungenPaketeCheckComplete
    {
        public int PaketId { get; set; }
        public int PaketAkteId { get; set; }
        public int? PapieraktenStatus { get; set; }
        public int? TeilbelegPapieraktenStatus { get; set; }
    }
}
