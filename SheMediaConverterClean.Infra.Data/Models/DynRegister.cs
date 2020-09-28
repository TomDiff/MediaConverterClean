using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynRegister
    {
        public DynRegister()
        {
            DynBeleg = new HashSet<DynBeleg>();
            SysBelegTyp = new HashSet<SysBelegTyp>();
        }

        public int RegisterId { get; set; }
        public string Ordnungsziffer { get; set; }
        public string Bezeichnung { get; set; }
        public bool? Aktiv { get; set; }
        public int? Sortierung { get; set; }
        public int RegisterTypId { get; set; }
        public int? AktenaufenthaltId { get; set; }

        public virtual ArcAktenaufenthalt Aktenaufenthalt { get; set; }
        public virtual DynRegisterTyp RegisterTyp { get; set; }
        public virtual ICollection<DynBeleg> DynBeleg { get; set; }
        public virtual ICollection<SysBelegTyp> SysBelegTyp { get; set; }
    }
}
