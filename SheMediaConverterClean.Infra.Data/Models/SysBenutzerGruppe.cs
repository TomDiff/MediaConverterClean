using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysBenutzerGruppe
    {
        public int BenutzerId { get; set; }
        public int GruppeId { get; set; }

        public virtual SysBenutzer Benutzer { get; set; }
        public virtual SysBenutzer Gruppe { get; set; }
    }
}
