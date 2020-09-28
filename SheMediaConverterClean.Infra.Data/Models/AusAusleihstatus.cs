using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class AusAusleihstatus
    {
        public int AusleihId { get; set; }
        public int AkteId { get; set; }
        public int? AngefordertDurchId { get; set; }
        public int? EmpfangendurchDurchId { get; set; }
        public DateTime? Ausleihdatum { get; set; }
        public DateTime? Faelligkeitsdatum { get; set; }
        public int? MahnStufeId { get; set; }
        public byte? AnzahlVerlaengerungen { get; set; }
        public int? AusleihEreignisgrundId { get; set; }
        public int? AusleihEreignisTypId { get; set; }
        public int? AusleihLagerOrtId { get; set; }
        public DateTime? AusleihErledigungsDatum { get; set; }
        public int? AusleihErledigungsartId { get; set; }
        public string Notiz { get; set; }

        public virtual ArcAkte Akte { get; set; }
        public virtual SysMitarbeiter AngefordertDurch { get; set; }
        public virtual SysEreignisTyp AusleihEreignisTyp { get; set; }
        public virtual SysEreignisgrund AusleihEreignisgrund { get; set; }
        public virtual SysErledigunsart AusleihErledigungsart { get; set; }
        public virtual ArcLagerOrt AusleihLagerOrt { get; set; }
        public virtual SysMitarbeiter EmpfangendurchDurch { get; set; }
        public virtual SysMahnstufe MahnStufe { get; set; }
    }
}
