using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynBelegProperties
    {
        public int BelegId { get; set; }
        public int BenutzerId { get; set; }
        public string AblagePfad { get; set; }
        public string PropertyKey { get; set; }
        public string PropertyValue { get; set; }
    }
}
