using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysEncryptKey
    {
        public int EncryptKeyId { get; set; }
        public string EncryptKey { get; set; }
        public string Iv { get; set; }
        public bool? Aktiv { get; set; }
    }
}
