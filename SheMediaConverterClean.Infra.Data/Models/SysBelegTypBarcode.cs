using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class SysBelegTypBarcode
    {
        public int BelegTypBarcodeId { get; set; }
        public int? BelegTypId { get; set; }
        public string BarcodeTyp { get; set; }
        public string Barcode { get; set; }
        public string BarcodeName { get; set; }
        public string FormularName { get; set; }
        public int? Sortierung { get; set; }

        public virtual SysBelegTyp BelegTyp { get; set; }
    }
}
