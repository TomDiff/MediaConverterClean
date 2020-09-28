using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysFrontendLog
    {
        public int? BenutzerId { get; set; }
        public DateTime? DatumUhrzeit { get; set; }
        public string Aktion { get; set; }

        public virtual SysBenutzer Benutzer { get; set; }
    }
}
