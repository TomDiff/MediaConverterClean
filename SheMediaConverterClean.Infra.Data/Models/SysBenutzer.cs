using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysBenutzer
    {
        public SysBenutzer()
        {
            GpBelegRechte = new HashSet<GpBelegRechte>();
            GpBelegVerweis = new HashSet<GpBelegVerweis>();
            SysBenutzerGruppeBenutzer = new HashSet<SysBenutzerGruppe>();
            SysBenutzerGruppeGruppe = new HashSet<SysBenutzerGruppe>();
            SysRecht = new HashSet<SysRecht>();
        }

        public int BenutzerId { get; set; }
        public int? PersonId { get; set; }
        public bool Gruppe { get; set; }
        public byte? StandardSichtRecht { get; set; }
        public byte? StandardDruckRecht { get; set; }

        public virtual SysMitarbeiter Person { get; set; }
        public virtual ICollection<GpBelegRechte> GpBelegRechte { get; set; }
        public virtual ICollection<GpBelegVerweis> GpBelegVerweis { get; set; }
        public virtual ICollection<SysBenutzerGruppe> SysBenutzerGruppeBenutzer { get; set; }
        public virtual ICollection<SysBenutzerGruppe> SysBenutzerGruppeGruppe { get; set; }
        public virtual ICollection<SysRecht> SysRecht { get; set; }
    }
}
