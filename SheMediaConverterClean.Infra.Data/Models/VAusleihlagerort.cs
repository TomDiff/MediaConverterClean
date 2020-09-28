using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAusleihlagerort
    {
        public string Bezeichnung { get; set; }
        public int Id { get; set; }
        public string Gang { get; set; }
        public string Regal { get; set; }
        public string Ebene { get; set; }
        public string Fach { get; set; }
        public int? HausId { get; set; }
    }
}
