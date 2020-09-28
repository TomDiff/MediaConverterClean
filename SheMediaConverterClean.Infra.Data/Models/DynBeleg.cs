using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class DynBeleg
    {
        public DynBeleg()
        {
            DynBelegSeiten = new HashSet<DynBelegSeiten>();
            InverseOberBeleg = new HashSet<DynBeleg>();
            OcrQueuedImage = new HashSet<OcrQueuedImage>();
            OcrResult = new HashSet<OcrResult>();
        }

        public int BelegId { get; set; }
        public int? AktenaufenthaltId { get; set; }
        public DateTime? Erfassungsdatum { get; set; }
        public int? ErfassungsMitarbeiterId { get; set; }
        public int? BelegTypId { get; set; }
        public int? BelegFormatId { get; set; }
        public int? PapierAktenStatusId { get; set; }
        public string Notiz { get; set; }
        public string Referenz { get; set; }
        public int? Seiten { get; set; }
        public string Ablagecode { get; set; }
        public string AblagecodeRollfilm { get; set; }
        public string AblagecodeDigital { get; set; }
        public int? SignaturNr { get; set; }
        public int? OberBelegId { get; set; }
        public string Bezeichnung { get; set; }
        public int? BesitzMitarbeiterId { get; set; }
        public string OcrText { get; set; }
        public byte[] Bild { get; set; }
        public int? Sortierung { get; set; }
        public int? BenutzerId { get; set; }
        public Guid VerweisGuid { get; set; }
        public Guid? OberBelegGuid { get; set; }
        public DateTime? ErfassungAuto { get; set; }
        public bool? IstEinzelbeleg { get; set; }
        public int? ArchivId { get; set; }
        public int? VertragId { get; set; }
        public int? EreignisId { get; set; }
        public int? MdmCompletionStatusId { get; set; }
        public int? MdmAvailabilityStatusId { get; set; }
        public int? MdmConfidentialityStatusId { get; set; }
        public string MdmUniqueDocumentNumber { get; set; }
        public string MdmParentDocumentNumber { get; set; }
        public bool Klassifiziert { get; set; }
        public bool MdmIsSended { get; set; }
        public string BelegTypVollstaendigerName { get; set; }
        public string BelegTypBeschreibung { get; set; }
        public int? BackupAktenaufenthaltId { get; set; }
        public int? DokumenttypId { get; set; }
        public string OriginalFileName { get; set; }
        public int? RegisterId { get; set; }
        public bool? IsVersion { get; set; }
        public string VersionId { get; set; }
        public string VersionControl { get; set; }
        public int? EncryptKeyId { get; set; }

        public virtual ArcAktenaufenthalt Aktenaufenthalt { get; set; }
        public virtual DynArchive Archiv { get; set; }
        public virtual SysBelegTyp BelegTyp { get; set; }
        public virtual DynDokumenttyp Dokumenttyp { get; set; }
        public virtual DynMdmAvailabilityStatus MdmAvailabilityStatus { get; set; }
        public virtual DynMdmCompletionStatus MdmCompletionStatus { get; set; }
        public virtual DynMdmConfidentialityStatus MdmConfidentialityStatus { get; set; }
        public virtual DynBeleg OberBeleg { get; set; }
        public virtual DynRegister Register { get; set; }
        public virtual ICollection<DynBelegSeiten> DynBelegSeiten { get; set; }
        public virtual ICollection<DynBeleg> InverseOberBeleg { get; set; }
        public virtual ICollection<OcrQueuedImage> OcrQueuedImage { get; set; }
        public virtual ICollection<OcrResult> OcrResult { get; set; }
    }
}
