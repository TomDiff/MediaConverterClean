using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VBelegTypBarcode
    {
        public int? BelegTypId { get; set; }
        public int BelegTypBarcodeId { get; set; }
        public string BarcodeTyp { get; set; }
        public string Barcode { get; set; }
        public string BarcodeName { get; set; }
        public string FormularName { get; set; }
        public string Bezeichnung { get; set; }
    }
}
