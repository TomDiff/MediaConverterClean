using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynAnnnotation
    {
        public int BelegId { get; set; }
        public int? BelegIndex { get; set; }
        public int BenutzerId { get; set; }
        public string AnnoData { get; set; }
        public int AnnotationTypId { get; set; }
        public string AblagePfad { get; set; }
    }
}
