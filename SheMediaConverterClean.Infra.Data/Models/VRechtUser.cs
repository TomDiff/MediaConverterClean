using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VRechtUser
    {
        public int BenutzerId { get; set; }
        public int EbeneId { get; set; }
        public int Id { get; set; }
        public byte Sicht { get; set; }
        public byte Druck { get; set; }
    }
}
