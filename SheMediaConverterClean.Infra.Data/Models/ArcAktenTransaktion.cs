using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class ArcAktenTransaktion
    {
        public ArcAktenTransaktion()
        {
            InverseUrAktenTransaktion = new HashSet<ArcAktenTransaktion>();
        }

        public int AktenTransaktionId { get; set; }
        public int? UrAktenTransaktionId { get; set; }
        public int? AkteId { get; set; }
        public int? BenutzerId { get; set; }
        public string BenutzerName { get; set; }
        public DateTime? EreignisDatum { get; set; }
        public int? EreignisTypId { get; set; }
        public int? EreignisGrundId { get; set; }
        public string EreignisGrundZusatz { get; set; }
        public string Aktennummer { get; set; }
        public int? MitarbeiterId { get; set; }
        public int? LagerOrtId { get; set; }
        public DateTime? Faelligkeit { get; set; }
        public int? PapieraktenStatusId { get; set; }
        public int? FreigabeStatusId { get; set; }
        public int? VerarbeitungsStatusId { get; set; }
        public string SollIst { get; set; }
        public int? MahnStufeId { get; set; }
        public DateTime? ErledigungsDatum { get; set; }
        public int? ErledigungsartId { get; set; }
        public DateTime? Aufnahmedatum { get; set; }
        public DateTime? Entlassungsdatum { get; set; }
        public int? AufenthaltsTypId { get; set; }

        public virtual ArcAkte Akte { get; set; }
        public virtual SysEreignisTyp EreignisTyp { get; set; }
        public virtual SysErledigunsart Erledigungsart { get; set; }
        public virtual ArcFreigabeStatus FreigabeStatus { get; set; }
        public virtual SysMahnstufe MahnStufe { get; set; }
        public virtual SysMitarbeiter Mitarbeiter { get; set; }
        public virtual ArcPapieraktenStatus PapieraktenStatus { get; set; }
        public virtual ArcAktenTransaktion UrAktenTransaktion { get; set; }
        public virtual ArcVerarbeitungsStatus VerarbeitungsStatus { get; set; }
        public virtual ICollection<ArcAktenTransaktion> InverseUrAktenTransaktion { get; set; }
    }
}
