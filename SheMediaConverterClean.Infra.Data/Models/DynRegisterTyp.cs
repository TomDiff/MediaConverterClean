using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynRegisterTyp
    {
        public DynRegisterTyp()
        {
            DynRegister = new HashSet<DynRegister>();
        }

        public int RegisterTypId { get; set; }
        public string Bezeichnung { get; set; }
        public int? Sortierung { get; set; }
        public string Barcode { get; set; }
        public string Notiz { get; set; }

        public virtual ICollection<DynRegister> DynRegister { get; set; }
    }
}
