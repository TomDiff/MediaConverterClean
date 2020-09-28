using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VBelegTypEbene
    {
        public int Index0 { get; set; }
        public int BelegId { get; set; }
        public int? BelegTypId { get; set; }
        public int? AktenaufenthaltId { get; set; }
        public string Bezeichnung { get; set; }
        public string Ablagepfad { get; set; }
        public int Expr1 { get; set; }
        public string BelegTyp { get; set; }
        public int? Sicht { get; set; }
        public int? Druck { get; set; }
        public string Expr2 { get; set; }
        public string NameToDisplay { get; set; }
        public bool? AnzeigePatient { get; set; }
        public int? PatientId { get; set; }
    }
}
