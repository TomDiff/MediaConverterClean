using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynTeilBeleg
    {
        public int TeilBelegId { get; set; }
        public int AkteId { get; set; }
        public int LfdNr { get; set; }
        public int PapieraktenStatusId { get; set; }
        public string Notiz { get; set; }
        public string BarcodeId { get; set; }
        public int? BelegTypId { get; set; }

        public virtual ArcAkte Akte { get; set; }
        public virtual SysBelegTyp BelegTyp { get; set; }
        public virtual ArcPapieraktenStatus PapieraktenStatus { get; set; }
    }
}
