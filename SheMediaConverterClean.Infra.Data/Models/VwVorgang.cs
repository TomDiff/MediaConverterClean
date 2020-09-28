using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwVorgang
    {
        public VwVorgang()
        {
            VwAktivitaet = new HashSet<VwAktivitaet>();
            VwEmailHistorie = new HashSet<VwEmailHistorie>();
            VwVorgangControlItem = new HashSet<VwVorgangControlItem>();
            VwVorgangHistorie = new HashSet<VwVorgangHistorie>();
            VwVorgangsdetail = new HashSet<VwVorgangsdetail>();
        }

        public int VorgangId { get; set; }
        public string Bezeichnung { get; set; }
        public string Fallnummer { get; set; }
        public DateTime? DatumAnfrage { get; set; }
        public DateTime? DatumAnlage { get; set; }
        public string BearbeiterAnlage { get; set; }
        public string BearbeiterDurchfuehrung { get; set; }
        public DateTime? DatumWiedervorlageBearbeiter { get; set; }
        public DateTime? DatumWiedervorlageEskalation { get; set; }
        public DateTime? DatumAbschluss { get; set; }
        public DateTime? DatumVersand { get; set; }
        public DateTime? DatumRueckfrage { get; set; }
        public string KommentarRueckfrage { get; set; }
        public int? ErledigungsstatusId { get; set; }
        public int? AnerkennungProzent { get; set; }
        public int? BearbeitungsstatusId { get; set; }
        public string Notiz { get; set; }
        public string MailadresseAuftraggeberVorgang { get; set; }
        public int? VorgangstypId { get; set; }
        public decimal? RechnungsbetragAnlage { get; set; }
        public decimal? RechnungsbetragAbschluss { get; set; }
        public string Drganlage { get; set; }
        public string Drgabschluss { get; set; }
        public DateTime? RechnungsDatumAnlage { get; set; }
        public DateTime? RechnungsDatumAbschluss { get; set; }
        public decimal? Streitwert { get; set; }
        public string ZuGunsten { get; set; }
        public int StandortId { get; set; }
        public string MdkId { get; set; }
        public DateTime? EmailGesendet { get; set; }
        public string EmailGesendetVon { get; set; }
        public string Kostentraeger { get; set; }
        public int? Verweildauerkuerzung { get; set; }
        public DateTime? AufenthaltVon { get; set; }
        public DateTime? AufenthaltBis { get; set; }
        public string FallnummerKenzeichnung { get; set; }

        public virtual VwBearbeitungsstatus Bearbeitungsstatus { get; set; }
        public virtual VwErledigungsstatus Erledigungsstatus { get; set; }
        public virtual VwStandort Standort { get; set; }
        public virtual VwVorgangstyp Vorgangstyp { get; set; }
        public virtual ICollection<VwAktivitaet> VwAktivitaet { get; set; }
        public virtual ICollection<VwEmailHistorie> VwEmailHistorie { get; set; }
        public virtual ICollection<VwVorgangControlItem> VwVorgangControlItem { get; set; }
        public virtual ICollection<VwVorgangHistorie> VwVorgangHistorie { get; set; }
        public virtual ICollection<VwVorgangsdetail> VwVorgangsdetail { get; set; }
    }
}
