using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcAkte
    {
        public ArcAkte()
        {
            ArcAktenTransaktion = new HashSet<ArcAktenTransaktion>();
            ArcAktenaufenthaltAkte = new HashSet<ArcAktenaufenthalt>();
            ArcAktenaufenthaltSammelakte = new HashSet<ArcAktenaufenthalt>();
            AusAnforderung = new HashSet<AusAnforderung>();
            AusAusleihstatus = new HashSet<AusAusleihstatus>();
            DynTeilBeleg = new HashSet<DynTeilBeleg>();
            LiePaketAkte = new HashSet<LiePaketAkte>();
        }

        public int AkteId { get; set; }
        public string Aktennummer { get; set; }
        public int? LagerOrtId { get; set; }
        public DateTime? Eingangsdatum { get; set; }
        public int? PapieraktenStatusId { get; set; }
        public int? FreigabeStatusId { get; set; }
        public int? ElektonischerStatusId { get; set; }
        public int? VerarbeitungsStatusId { get; set; }
        public int? LetzterEreignisTypId { get; set; }
        public int? MahnStufeId { get; set; }
        public string Referenz { get; set; }
        public string Anmerkung { get; set; }
        public int? AktenTypId { get; set; }
        public int? EinzelbelegStatusId { get; set; }
        public string Notiz { get; set; }

        public virtual ArcAktentyp AktenTyp { get; set; }
        public virtual ArcEinzelbelegStatus EinzelbelegStatus { get; set; }
        public virtual ArcElektronischerStatus ElektonischerStatus { get; set; }
        public virtual ArcFreigabeStatus FreigabeStatus { get; set; }
        public virtual ArcLagerOrt LagerOrt { get; set; }
        public virtual SysEreignisTyp LetzterEreignisTyp { get; set; }
        public virtual SysMahnstufe MahnStufe { get; set; }
        public virtual ArcPapieraktenStatus PapieraktenStatus { get; set; }
        public virtual ArcVerarbeitungsStatus VerarbeitungsStatus { get; set; }
        public virtual ICollection<ArcAktenTransaktion> ArcAktenTransaktion { get; set; }
        public virtual ICollection<ArcAktenaufenthalt> ArcAktenaufenthaltAkte { get; set; }
        public virtual ICollection<ArcAktenaufenthalt> ArcAktenaufenthaltSammelakte { get; set; }
        public virtual ICollection<AusAnforderung> AusAnforderung { get; set; }
        public virtual ICollection<AusAusleihstatus> AusAusleihstatus { get; set; }
        public virtual ICollection<DynTeilBeleg> DynTeilBeleg { get; set; }
        public virtual ICollection<LiePaketAkte> LiePaketAkte { get; set; }
    }
}
