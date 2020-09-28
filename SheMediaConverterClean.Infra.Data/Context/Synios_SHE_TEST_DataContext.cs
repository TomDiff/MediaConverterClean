using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class Synios_SHE_TEST_DataContext : DbContext
    {
        public Synios_SHE_TEST_DataContext()
        {
        }

        public Synios_SHE_TEST_DataContext(DbContextOptions<Synios_SHE_TEST_DataContext> options) : base(options)
        {
        }

        public virtual DbSet<ArcAkte> ArcAkte { get; set; }
        public virtual DbSet<ArcAktenTransaktion> ArcAktenTransaktion { get; set; }
        public virtual DbSet<ArcAktenaufenthalt> ArcAktenaufenthalt { get; set; }
        public virtual DbSet<ArcAktenaufenthaltStatus> ArcAktenaufenthaltStatus { get; set; }
        public virtual DbSet<ArcAktentyp> ArcAktentyp { get; set; }
        public virtual DbSet<ArcArchiv> ArcArchiv { get; set; }
        public virtual DbSet<ArcEinzelbelegStatus> ArcEinzelbelegStatus { get; set; }
        public virtual DbSet<ArcElektronischerStatus> ArcElektronischerStatus { get; set; }
        public virtual DbSet<ArcFreigabeStatus> ArcFreigabeStatus { get; set; }
        public virtual DbSet<ArcLagerOrt> ArcLagerOrt { get; set; }
        public virtual DbSet<ArcPapieraktenStatus> ArcPapieraktenStatus { get; set; }
        public virtual DbSet<ArcVerarbeitungsStatus> ArcVerarbeitungsStatus { get; set; }
        public virtual DbSet<AusAnforderung> AusAnforderung { get; set; }
        public virtual DbSet<AusAusleihstatus> AusAusleihstatus { get; set; }
        public virtual DbSet<BurnMedia> BurnMedia { get; set; }
        public virtual DbSet<DynAnnnotation> DynAnnnotation { get; set; }
        public virtual DbSet<DynArchive> DynArchive { get; set; }
        public virtual DbSet<DynAufenthalt> DynAufenthalt { get; set; }
        public virtual DbSet<DynAufenthaltsTyp> DynAufenthaltsTyp { get; set; }
        public virtual DbSet<DynAusleiheUserFachabteilung> DynAusleiheUserFachabteilung { get; set; }
        public virtual DbSet<DynBeleg> DynBeleg { get; set; }
        public virtual DbSet<DynBelegProperties> DynBelegProperties { get; set; }
        public virtual DbSet<DynBelegSeiten> DynBelegSeiten { get; set; }
        public virtual DbSet<DynDokumentStrukturtyp> DynDokumentStrukturtyp { get; set; }
        public virtual DbSet<DynDokumenttyp> DynDokumenttyp { get; set; }
        public virtual DbSet<DynDokumenttypMatching> DynDokumenttypMatching { get; set; }
        public virtual DbSet<DynFachabteilung> DynFachabteilung { get; set; }
        public virtual DbSet<DynHaus> DynHaus { get; set; }
        public virtual DbSet<DynMdmAvailabilityStatus> DynMdmAvailabilityStatus { get; set; }
        public virtual DbSet<DynMdmCompletionStatus> DynMdmCompletionStatus { get; set; }
        public virtual DbSet<DynMdmConfidentialityStatus> DynMdmConfidentialityStatus { get; set; }
        public virtual DbSet<DynPatient> DynPatient { get; set; }
        public virtual DbSet<DynRegister> DynRegister { get; set; }
        public virtual DbSet<DynRegisterTyp> DynRegisterTyp { get; set; }
        public virtual DbSet<DynStandort> DynStandort { get; set; }
        public virtual DbSet<DynStation> DynStation { get; set; }
        public virtual DbSet<DynStruktur> DynStruktur { get; set; }
        public virtual DbSet<DynTeilBeleg> DynTeilBeleg { get; set; }
        public virtual DbSet<GpBelegRechte> GpBelegRechte { get; set; }
        public virtual DbSet<GpBelegVerweis> GpBelegVerweis { get; set; }
        public virtual DbSet<LieLieferung> LieLieferung { get; set; }
        public virtual DbSet<LiePaket> LiePaket { get; set; }
        public virtual DbSet<LiePaketAkte> LiePaketAkte { get; set; }
        public virtual DbSet<ManuellerLieferbericht> ManuellerLieferbericht { get; set; }
        public virtual DbSet<OcrQueuedImage> OcrQueuedImage { get; set; }
        public virtual DbSet<OcrResult> OcrResult { get; set; }
        public virtual DbSet<Oidbex3> Oidbex3 { get; set; }
        public virtual DbSet<PaketVerwaltung> PaketVerwaltung { get; set; }
        public virtual DbSet<SysBelegTyp> SysBelegTyp { get; set; }
        public virtual DbSet<SysBelegTypBarcode> SysBelegTypBarcode { get; set; }
        public virtual DbSet<SysBenutzer> SysBenutzer { get; set; }
        public virtual DbSet<SysBenutzerGruppe> SysBenutzerGruppe { get; set; }
        public virtual DbSet<SysBurnWishListItems> SysBurnWishListItems { get; set; }
        public virtual DbSet<SysEncryptKey> SysEncryptKey { get; set; }
        public virtual DbSet<SysEreignisTyp> SysEreignisTyp { get; set; }
        public virtual DbSet<SysEreignisgrund> SysEreignisgrund { get; set; }
        public virtual DbSet<SysErledigunsart> SysErledigunsart { get; set; }
        public virtual DbSet<SysFrontendLog> SysFrontendLog { get; set; }
        public virtual DbSet<SysIcon> SysIcon { get; set; }
        public virtual DbSet<SysMahnstufe> SysMahnstufe { get; set; }
        public virtual DbSet<SysMitarbeiter> SysMitarbeiter { get; set; }
        public virtual DbSet<SysRecht> SysRecht { get; set; }
        public virtual DbSet<VAkteAngefordert> VAkteAngefordert { get; set; }
        public virtual DbSet<VAkteAufenthalt> VAkteAufenthalt { get; set; }
        public virtual DbSet<VAkteAufenthaltKlartext> VAkteAufenthaltKlartext { get; set; }
        public virtual DbSet<VAkteVerpacken> VAkteVerpacken { get; set; }
        public virtual DbSet<VAktenTyp> VAktenTyp { get; set; }
        public virtual DbSet<VAktenhistorie> VAktenhistorie { get; set; }
        public virtual DbSet<VAktenhistorieErweitert> VAktenhistorieErweitert { get; set; }
        public virtual DbSet<VAlleVerweise> VAlleVerweise { get; set; }
        public virtual DbSet<VArchivlagerort> VArchivlagerort { get; set; }
        public virtual DbSet<VArchivverwaltungStandard> VArchivverwaltungStandard { get; set; }
        public virtual DbSet<VAufenthaltEbene> VAufenthaltEbene { get; set; }
        public virtual DbSet<VAusleihgrund> VAusleihgrund { get; set; }
        public virtual DbSet<VAusleihlagerort> VAusleihlagerort { get; set; }
        public virtual DbSet<VAusleihstatusKlartext> VAusleihstatusKlartext { get; set; }
        public virtual DbSet<VAusleihverwaltungStandard> VAusleihverwaltungStandard { get; set; }
        public virtual DbSet<VAusleihverwaltungStation> VAusleihverwaltungStation { get; set; }
        public virtual DbSet<VBarcodeAufenthalt> VBarcodeAufenthalt { get; set; }
        public virtual DbSet<VBarcodePatientAufenthalt> VBarcodePatientAufenthalt { get; set; }
        public virtual DbSet<VBarcodeStandard> VBarcodeStandard { get; set; }
        public virtual DbSet<VBaumBelegEbene> VBaumBelegEbene { get; set; }
        public virtual DbSet<VBelegEbene> VBelegEbene { get; set; }
        public virtual DbSet<VBelegTypBarcode> VBelegTypBarcode { get; set; }
        public virtual DbSet<VBelegTypEbene> VBelegTypEbene { get; set; }
        public virtual DbSet<VDokumenttyp> VDokumenttyp { get; set; }
        public virtual DbSet<VDokumenttypMatching> VDokumenttypMatching { get; set; }
        public virtual DbSet<VEbene2> VEbene2 { get; set; }
        public virtual DbSet<VFreigegebeneBelegVerweise> VFreigegebeneBelegVerweise { get; set; }
        public virtual DbSet<VLieferungAusdruck> VLieferungAusdruck { get; set; }
        public virtual DbSet<VLieferungStation> VLieferungStation { get; set; }
        public virtual DbSet<VLieferungTeilBeleg> VLieferungTeilBeleg { get; set; }
        public virtual DbSet<VLieferungen> VLieferungen { get; set; }
        public virtual DbSet<VLieferungenPakete> VLieferungenPakete { get; set; }
        public virtual DbSet<VLieferungenPaketeCheckComplete> VLieferungenPaketeCheckComplete { get; set; }
        public virtual DbSet<VNeuePakete> VNeuePakete { get; set; }
        public virtual DbSet<VRecht> VRecht { get; set; }
        public virtual DbSet<VRechtUser> VRechtUser { get; set; }
        public virtual DbSet<VRegister> VRegister { get; set; }
        public virtual DbSet<VRegisterEbene> VRegisterEbene { get; set; }
        public virtual DbSet<VRptAktenbewegung> VRptAktenbewegung { get; set; }
        public virtual DbSet<VStrukturAkut> VStrukturAkut { get; set; }
        public virtual DbSet<VStrukturAkutEbene> VStrukturAkutEbene { get; set; }
        public virtual DbSet<VStrukturEfa> VStrukturEfa { get; set; }
        public virtual DbSet<VStrukturEfaEbene> VStrukturEfaEbene { get; set; }
        public virtual DbSet<VStrukturReha> VStrukturReha { get; set; }
        public virtual DbSet<VStrukturRehaEbene> VStrukturRehaEbene { get; set; }
        public virtual DbSet<VSysBelegEbene> VSysBelegEbene { get; set; }
        public virtual DbSet<VTeilBelege> VTeilBelege { get; set; }
        public virtual DbSet<VXrayErfassen> VXrayErfassen { get; set; }
        public virtual DbSet<VXrayErfassenAllow> VXrayErfassenAllow { get; set; }
        public virtual DbSet<VwAktionstyp> VwAktionstyp { get; set; }
        public virtual DbSet<VwAktivitaet> VwAktivitaet { get; set; }
        public virtual DbSet<VwAktivitaetErledigungsstatus> VwAktivitaetErledigungsstatus { get; set; }
        public virtual DbSet<VwBearbeitungsstatus> VwBearbeitungsstatus { get; set; }
        public virtual DbSet<VwBelegverweis> VwBelegverweis { get; set; }
        public virtual DbSet<VwBelegverweisTyp> VwBelegverweisTyp { get; set; }
        public virtual DbSet<VwBelegverweisVorgang> VwBelegverweisVorgang { get; set; }
        public virtual DbSet<VwConfiguration> VwConfiguration { get; set; }
        public virtual DbSet<VwControl> VwControl { get; set; }
        public virtual DbSet<VwControlItem> VwControlItem { get; set; }
        public virtual DbSet<VwEmailHistorie> VwEmailHistorie { get; set; }
        public virtual DbSet<VwErledigungsstatus> VwErledigungsstatus { get; set; }
        public virtual DbSet<VwExtraPatientInformations> VwExtraPatientInformations { get; set; }
        public virtual DbSet<VwFelder> VwFelder { get; set; }
        public virtual DbSet<VwServiceLog> VwServiceLog { get; set; }
        public virtual DbSet<VwStandort> VwStandort { get; set; }
        public virtual DbSet<VwStandortUser> VwStandortUser { get; set; }
        public virtual DbSet<VwStatistik> VwStatistik { get; set; }
        public virtual DbSet<VwStatistikItem> VwStatistikItem { get; set; }
        public virtual DbSet<VwVorgang> VwVorgang { get; set; }
        public virtual DbSet<VwVorgangControlItem> VwVorgangControlItem { get; set; }
        public virtual DbSet<VwVorgangHistorie> VwVorgangHistorie { get; set; }
        public virtual DbSet<VwVorgangsbereich> VwVorgangsbereich { get; set; }
        public virtual DbSet<VwVorgangsdetail> VwVorgangsdetail { get; set; }
        public virtual DbSet<VwVorgangstyp> VwVorgangstyp { get; set; }
        public virtual DbSet<VwVorgangstypdetail> VwVorgangstypdetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=NB-SYNIOS21\\SQLEXPRESS;Initial Catalog=Synios_SHE_TEST_Data;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArcAkte>(entity =>
            {
                entity.HasKey(e => e.AkteId);

                entity.ToTable("Arc_Akte");

                entity.HasIndex(e => e.Aktennummer);

                entity.HasIndex(e => e.EinzelbelegStatusId);

                entity.HasIndex(e => e.ElektonischerStatusId);

                entity.HasIndex(e => e.FreigabeStatusId);

                entity.HasIndex(e => e.LagerOrtId);

                entity.HasIndex(e => e.LetzterEreignisTypId);

                entity.HasIndex(e => e.MahnStufeId);

                entity.HasIndex(e => e.PapieraktenStatusId);

                entity.HasIndex(e => e.Referenz);

                entity.HasIndex(e => e.VerarbeitungsStatusId);

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AktenTypId).HasColumnName("AktenTyp_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Anmerkung).HasMaxLength(2000);

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.EinzelbelegStatusId).HasColumnName("EinzelbelegStatus_ID");

                entity.Property(e => e.ElektonischerStatusId).HasColumnName("ElektonischerStatus_ID");

                entity.Property(e => e.FreigabeStatusId).HasColumnName("FreigabeStatus_ID");

                entity.Property(e => e.LagerOrtId).HasColumnName("LagerOrt_ID");

                entity.Property(e => e.LetzterEreignisTypId).HasColumnName("LetzterEreignisTyp_ID");

                entity.Property(e => e.MahnStufeId).HasColumnName("MahnStufe_ID");

                entity.Property(e => e.Notiz)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PapieraktenStatusId).HasColumnName("PapieraktenStatus_ID");

                entity.Property(e => e.Referenz)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerarbeitungsStatusId).HasColumnName("VerarbeitungsStatus_ID");

                entity.HasOne(d => d.AktenTyp)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.AktenTypId)
                    .HasConstraintName("FK_Arc_Akte_Arc_Aktentyp");

                entity.HasOne(d => d.EinzelbelegStatus)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.EinzelbelegStatusId)
                    .HasConstraintName("FK_Arc_Akte_Arc_EinzelbelegStatus");

                entity.HasOne(d => d.ElektonischerStatus)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.ElektonischerStatusId)
                    .HasConstraintName("FK_Arc_Akte_Arc_ElektronischerStatus");

                entity.HasOne(d => d.FreigabeStatus)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.FreigabeStatusId)
                    .HasConstraintName("FK_Arc_Akte_Arc_FreigabeStatus");

                entity.HasOne(d => d.LagerOrt)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.LagerOrtId)
                    .HasConstraintName("FK_Arc_Akte_Arc_LagerOrt");

                entity.HasOne(d => d.LetzterEreignisTyp)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.LetzterEreignisTypId)
                    .HasConstraintName("FK_Arc_Akte_Arc_EreignisTyp");

                entity.HasOne(d => d.MahnStufe)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.MahnStufeId)
                    .HasConstraintName("FK_Arc_Akte_Arc_Mahnstufe");

                entity.HasOne(d => d.PapieraktenStatus)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.PapieraktenStatusId)
                    .HasConstraintName("FK_Arc_Akte_Arc_PapieraktenStatus");

                entity.HasOne(d => d.VerarbeitungsStatus)
                    .WithMany(p => p.ArcAkte)
                    .HasForeignKey(d => d.VerarbeitungsStatusId)
                    .HasConstraintName("FK_Arc_Akte_Arc_VerarbeitungsStatus");
            });

            modelBuilder.Entity<ArcAktenTransaktion>(entity =>
            {
                entity.HasKey(e => e.AktenTransaktionId)
                    .HasName("PK_Aktenhistorie");

                entity.ToTable("Arc_AktenTransaktion");

                entity.HasIndex(e => e.AkteId);

                entity.HasIndex(e => e.EreignisDatum);

                entity.HasIndex(e => e.EreignisGrundId);

                entity.HasIndex(e => e.EreignisTypId);

                entity.HasIndex(e => e.ErledigungsartId);

                entity.HasIndex(e => e.FreigabeStatusId);

                entity.HasIndex(e => e.LagerOrtId);

                entity.HasIndex(e => e.MahnStufeId);

                entity.HasIndex(e => e.PapieraktenStatusId);

                entity.HasIndex(e => e.SollIst);

                entity.HasIndex(e => e.UrAktenTransaktionId);

                entity.HasIndex(e => e.VerarbeitungsStatusId);

                entity.Property(e => e.AktenTransaktionId).HasColumnName("AktenTransaktion_ID");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltsTypId).HasColumnName("AufenthaltsTyp_ID");

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.EreignisDatum)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EreignisGrundId).HasColumnName("EreignisGrund_ID");

                entity.Property(e => e.EreignisGrundZusatz).HasColumnType("ntext");

                entity.Property(e => e.EreignisTypId).HasColumnName("EreignisTyp_ID");

                entity.Property(e => e.ErledigungsDatum).HasColumnType("datetime");

                entity.Property(e => e.ErledigungsartId).HasColumnName("Erledigungsart_ID");

                entity.Property(e => e.Faelligkeit).HasColumnType("datetime");

                entity.Property(e => e.FreigabeStatusId).HasColumnName("FreigabeStatus_ID");

                entity.Property(e => e.LagerOrtId).HasColumnName("LagerOrt_ID");

                entity.Property(e => e.MahnStufeId).HasColumnName("MahnStufe_ID");

                entity.Property(e => e.MitarbeiterId).HasColumnName("Mitarbeiter_ID");

                entity.Property(e => e.PapieraktenStatusId).HasColumnName("PapieraktenStatus_ID");

                entity.Property(e => e.SollIst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.UrAktenTransaktionId).HasColumnName("UrAktenTransaktion_ID");

                entity.Property(e => e.VerarbeitungsStatusId).HasColumnName("VerarbeitungsStatus_ID");

                entity.HasOne(d => d.Akte)
                    .WithMany(p => p.ArcAktenTransaktion)
                    .HasForeignKey(d => d.AkteId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Arc_Aktenhistorie_Arc_Akte");

                entity.HasOne(d => d.EreignisTyp)
                    .WithMany(p => p.ArcAktenTransaktion)
                    .HasForeignKey(d => d.EreignisTypId)
                    .HasConstraintName("FK_Arc_AktenTransaktion_Sys_ErignisTyp");

                entity.HasOne(d => d.Erledigungsart)
                    .WithMany(p => p.ArcAktenTransaktion)
                    .HasForeignKey(d => d.ErledigungsartId)
                    .HasConstraintName("FK_Arc_AktenTransaktion_Arc_Erledigunsart");

                entity.HasOne(d => d.FreigabeStatus)
                    .WithMany(p => p.ArcAktenTransaktion)
                    .HasForeignKey(d => d.FreigabeStatusId)
                    .HasConstraintName("FK_Arc_AktenTransaktion_Arc_FreigabeStatus");

                entity.HasOne(d => d.MahnStufe)
                    .WithMany(p => p.ArcAktenTransaktion)
                    .HasForeignKey(d => d.MahnStufeId)
                    .HasConstraintName("FK_Arc_AktenTransaktion_Arc_Mahnstufe");

                entity.HasOne(d => d.Mitarbeiter)
                    .WithMany(p => p.ArcAktenTransaktion)
                    .HasForeignKey(d => d.MitarbeiterId)
                    .HasConstraintName("FK_Arc_Aktenhistorie_Sys_Mitarbeiter");

                entity.HasOne(d => d.PapieraktenStatus)
                    .WithMany(p => p.ArcAktenTransaktion)
                    .HasForeignKey(d => d.PapieraktenStatusId)
                    .HasConstraintName("FK_Arc_AktenTransaktion_Arc_PapieraktenStatus");

                entity.HasOne(d => d.UrAktenTransaktion)
                    .WithMany(p => p.InverseUrAktenTransaktion)
                    .HasForeignKey(d => d.UrAktenTransaktionId)
                    .HasConstraintName("FK_Arc_AktenTransaktion_Arc_AktenTransaktion");

                entity.HasOne(d => d.VerarbeitungsStatus)
                    .WithMany(p => p.ArcAktenTransaktion)
                    .HasForeignKey(d => d.VerarbeitungsStatusId)
                    .HasConstraintName("FK_Arc_AktenTransaktion_Arc_VerarbeitungsStatus");
            });

            modelBuilder.Entity<ArcAktenaufenthalt>(entity =>
            {
                entity.HasKey(e => e.AktenaufenthaltId);

                entity.ToTable("Arc_Aktenaufenthalt");

                entity.HasIndex(e => e.AkteId);

                entity.HasIndex(e => e.AktenaufenthaltStatusId);

                entity.HasIndex(e => e.AufenthaltId);

                entity.HasIndex(e => e.AufenthaltsTypId);

                entity.HasIndex(e => e.FachabteilungId);

                entity.HasIndex(e => e.SammelakteId);

                entity.HasIndex(e => e.StationId);

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AktenaufenthaltStatusId)
                    .HasColumnName("AktenaufenthaltStatus_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_Id");

                entity.Property(e => e.AufenthaltsTypId).HasColumnName("AufenthaltsTyp_ID");

                entity.Property(e => e.FachabteilungId).HasColumnName("Fachabteilung_ID");

                entity.Property(e => e.Notiz)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SammelakteId).HasColumnName("Sammelakte_ID");

                entity.Property(e => e.StationId).HasColumnName("Station_ID");

                entity.HasOne(d => d.Akte)
                    .WithMany(p => p.ArcAktenaufenthaltAkte)
                    .HasForeignKey(d => d.AkteId)
                    .HasConstraintName("FK_Arc_Aktenaufenthalt_Arc_Akte");

                entity.HasOne(d => d.AktenaufenthaltStatus)
                    .WithMany(p => p.ArcAktenaufenthalt)
                    .HasForeignKey(d => d.AktenaufenthaltStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Arc_Aufenthaltsakte_Arc_AufenthaltsStatus");

                entity.HasOne(d => d.Aufenthalt)
                    .WithMany(p => p.ArcAktenaufenthalt)
                    .HasForeignKey(d => d.AufenthaltId)
                    .HasConstraintName("FK_Arc_Aktenaufenthalt_Dyn_Aufenthalt");

                entity.HasOne(d => d.AufenthaltsTyp)
                    .WithMany(p => p.ArcAktenaufenthalt)
                    .HasForeignKey(d => d.AufenthaltsTypId)
                    .HasConstraintName("FK_Arc_Aktenaufenthalt_Dyn_AufenthaltsTyp");

                entity.HasOne(d => d.Fachabteilung)
                    .WithMany(p => p.ArcAktenaufenthalt)
                    .HasForeignKey(d => d.FachabteilungId)
                    .HasConstraintName("FK_Arc_Aufenthaltsakte_Dyn_Fachabteilung");

                entity.HasOne(d => d.Sammelakte)
                    .WithMany(p => p.ArcAktenaufenthaltSammelakte)
                    .HasForeignKey(d => d.SammelakteId)
                    .HasConstraintName("FK_Arc_Aktenaufenthalt_Arc_Akte1");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.ArcAktenaufenthalt)
                    .HasForeignKey(d => d.StationId)
                    .HasConstraintName("FK_Arc_Aufenthaltsakte_Dyn_Station");
            });

            modelBuilder.Entity<ArcAktenaufenthaltStatus>(entity =>
            {
                entity.HasKey(e => e.AktenaufenthaltStatusId)
                    .HasName("PK__Arc_Akte__EDF82F23757C27E4");

                entity.ToTable("Arc_AktenaufenthaltStatus");

                entity.Property(e => e.AktenaufenthaltStatusId).HasColumnName("AktenaufenthaltStatus_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArcAktentyp>(entity =>
            {
                entity.HasKey(e => e.AktenTypId);

                entity.ToTable("Arc_Aktentyp");

                entity.Property(e => e.AktenTypId).HasColumnName("AktenTyp_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArcArchiv>(entity =>
            {
                entity.HasKey(e => e.ArchivId)
                    .HasName("PK_Archiv");

                entity.ToTable("Arc_Archiv");

                entity.HasIndex(e => e.AbteilungId);

                entity.HasIndex(e => new { e.Bezeichnung, e.AbteilungId })
                    .IsUnique();

                entity.Property(e => e.ArchivId).HasColumnName("Archiv_ID");

                entity.Property(e => e.AbteilungId).HasColumnName("Abteilung_ID");

                entity.Property(e => e.ArchivGuid).HasColumnName("Archiv_GUID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.IstArchiv).HasColumnName("istArchiv");

                entity.HasOne(d => d.Abteilung)
                    .WithMany(p => p.ArcArchiv)
                    .HasForeignKey(d => d.AbteilungId)
                    .HasConstraintName("FK_Arc_Archiv_Dyn_Station");

                entity.HasOne(d => d.Haus)
                    .WithMany(p => p.ArcArchiv)
                    .HasForeignKey(d => d.HausId)
                    .HasConstraintName("FK_Arc_Archiv_Dyn_Haus");
            });

            modelBuilder.Entity<ArcEinzelbelegStatus>(entity =>
            {
                entity.HasKey(e => e.EinzelbelegStatusId);

                entity.ToTable("Arc_EinzelbelegStatus");

                entity.Property(e => e.EinzelbelegStatusId)
                    .HasColumnName("EinzelbelegStatus_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ArcElektronischerStatus>(entity =>
            {
                entity.HasKey(e => e.ElektonischerStatusId);

                entity.ToTable("Arc_ElektronischerStatus");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("UIX_Arc_ElektronischerStatus_Bezeichnung")
                    .IsUnique();

                entity.Property(e => e.ElektonischerStatusId)
                    .HasColumnName("ElektonischerStatus_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArcFreigabeStatus>(entity =>
            {
                entity.HasKey(e => e.FreigabeStatusId);

                entity.ToTable("Arc_FreigabeStatus");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("UIX_Arc_FreigabeStatus_Bezeichnung")
                    .IsUnique();

                entity.Property(e => e.FreigabeStatusId)
                    .HasColumnName("FreigabeStatus_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArcLagerOrt>(entity =>
            {
                entity.HasKey(e => e.LagerOrtId);

                entity.ToTable("Arc_LagerOrt");

                entity.HasIndex(e => e.ArchivId);

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("IX_Arc_LagerOrt");

                entity.Property(e => e.LagerOrtId).HasColumnName("LagerOrt_ID");

                entity.Property(e => e.ArchivId).HasColumnName("Archiv_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ebene)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Regal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Archiv)
                    .WithMany(p => p.ArcLagerOrt)
                    .HasForeignKey(d => d.ArchivId)
                    .HasConstraintName("FK_Arc_LagerOrt_Arc_Archiv");
            });

            modelBuilder.Entity<ArcPapieraktenStatus>(entity =>
            {
                entity.HasKey(e => e.PapieraktenStatusId);

                entity.ToTable("Arc_PapieraktenStatus");

                entity.HasIndex(e => e.Bezeichnung)
                    .IsUnique();

                entity.Property(e => e.PapieraktenStatusId)
                    .HasColumnName("PapieraktenStatus_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ArcVerarbeitungsStatus>(entity =>
            {
                entity.HasKey(e => e.VerarbeitungsStatusId);

                entity.ToTable("Arc_VerarbeitungsStatus");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("UIX_Arc_VerarbeitungsStatus_Bezeichnung")
                    .IsUnique();

                entity.Property(e => e.VerarbeitungsStatusId)
                    .HasColumnName("VerarbeitungsStatus_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AusAnforderung>(entity =>
            {
                entity.HasKey(e => e.AnforderungId);

                entity.ToTable("Aus_Anforderung");

                entity.HasIndex(e => e.AkteId);

                entity.HasIndex(e => e.AnfordererId);

                entity.HasIndex(e => e.MitarbeiterId);

                entity.Property(e => e.AnforderungId).HasColumnName("Anforderung_ID");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AnfordererId).HasColumnName("Anforderer_ID");

                entity.Property(e => e.AnfordererNameKlartext)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnforderungsDatum).HasColumnType("smalldatetime");

                entity.Property(e => e.AusleihEreignisgrundId).HasColumnName("AusleihEreignisgrund_ID");

                entity.Property(e => e.MitarbeiterId).HasColumnName("Mitarbeiter_ID");

                entity.HasOne(d => d.Akte)
                    .WithMany(p => p.AusAnforderung)
                    .HasForeignKey(d => d.AkteId)
                    .HasConstraintName("FK_Aus_Anforderung_Arc_Akte");

                entity.HasOne(d => d.AusleihEreignisgrund)
                    .WithMany(p => p.AusAnforderung)
                    .HasForeignKey(d => d.AusleihEreignisgrundId)
                    .HasConstraintName("FK_Aus_Anforderung_Sys_Ereignisgrund");
            });

            modelBuilder.Entity<AusAusleihstatus>(entity =>
            {
                entity.HasKey(e => e.AusleihId);

                entity.ToTable("Aus_Ausleihstatus");

                entity.HasIndex(e => e.AkteId);

                entity.HasIndex(e => e.AngefordertDurchId);

                entity.HasIndex(e => e.AusleihLagerOrtId);

                entity.HasIndex(e => e.Ausleihdatum);

                entity.HasIndex(e => e.EmpfangendurchDurchId);

                entity.HasIndex(e => e.Faelligkeitsdatum);

                entity.Property(e => e.AusleihId).HasColumnName("Ausleih_ID");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AngefordertDurchId).HasColumnName("AngefordertDurch_ID");

                entity.Property(e => e.AusleihEreignisTypId).HasColumnName("AusleihEreignisTyp_ID");

                entity.Property(e => e.AusleihEreignisgrundId).HasColumnName("AusleihEreignisgrund_ID");

                entity.Property(e => e.AusleihErledigungsDatum).HasColumnType("smalldatetime");

                entity.Property(e => e.AusleihErledigungsartId).HasColumnName("AusleihErledigungsart_ID");

                entity.Property(e => e.AusleihLagerOrtId).HasColumnName("AusleihLagerOrt_ID");

                entity.Property(e => e.Ausleihdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.EmpfangendurchDurchId).HasColumnName("EmpfangendurchDurch_ID");

                entity.Property(e => e.Faelligkeitsdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.MahnStufeId).HasColumnName("MahnStufe_ID");

                entity.Property(e => e.Notiz).HasColumnType("ntext");

                entity.HasOne(d => d.Akte)
                    .WithMany(p => p.AusAusleihstatus)
                    .HasForeignKey(d => d.AkteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Aus_Ausleihstatus_Arc_Akte");

                entity.HasOne(d => d.AngefordertDurch)
                    .WithMany(p => p.AusAusleihstatusAngefordertDurch)
                    .HasForeignKey(d => d.AngefordertDurchId)
                    .HasConstraintName("FK_Aus_Ausleihstatus_Sys_Mitarbeiter");

                entity.HasOne(d => d.AusleihEreignisTyp)
                    .WithMany(p => p.AusAusleihstatus)
                    .HasForeignKey(d => d.AusleihEreignisTypId)
                    .HasConstraintName("FK_Aus_Ausleihstatus_Arc_EreignisTyp");

                entity.HasOne(d => d.AusleihEreignisgrund)
                    .WithMany(p => p.AusAusleihstatus)
                    .HasForeignKey(d => d.AusleihEreignisgrundId)
                    .HasConstraintName("FK_Aus_Ausleihstatus_Sys_Ereignisgrund");

                entity.HasOne(d => d.AusleihErledigungsart)
                    .WithMany(p => p.AusAusleihstatus)
                    .HasForeignKey(d => d.AusleihErledigungsartId)
                    .HasConstraintName("FK_Aus_Ausleihstatus_Arc_Erledigunsart");

                entity.HasOne(d => d.AusleihLagerOrt)
                    .WithMany(p => p.AusAusleihstatus)
                    .HasForeignKey(d => d.AusleihLagerOrtId)
                    .HasConstraintName("FK_Aus_Ausleihstatus_Arc_LagerOrt");

                entity.HasOne(d => d.EmpfangendurchDurch)
                    .WithMany(p => p.AusAusleihstatusEmpfangendurchDurch)
                    .HasForeignKey(d => d.EmpfangendurchDurchId)
                    .HasConstraintName("FK_Aus_Ausleihstatus_Sys_Mitarbeiter1");

                entity.HasOne(d => d.MahnStufe)
                    .WithMany(p => p.AusAusleihstatus)
                    .HasForeignKey(d => d.MahnStufeId)
                    .HasConstraintName("FK_Aus_Ausleihstatus_Arc_Mahnstufe1");
            });

            modelBuilder.Entity<BurnMedia>(entity =>
            {
                entity.HasIndex(e => e.Name);

                entity.Property(e => e.BurnMediaId).HasColumnName("BurnMedia_ID");

                entity.Property(e => e.DiscSize)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DynAnnnotation>(entity =>
            {
                entity.HasKey(e => new { e.BelegId, e.BenutzerId, e.AnnotationTypId, e.AblagePfad });

                entity.ToTable("Dyn_Annnotation");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.AnnotationTypId)
                    .HasColumnName("AnnotationTypID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AblagePfad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AnnoData).IsUnicode(false);
            });

            modelBuilder.Entity<DynArchive>(entity =>
            {
                entity.HasKey(e => e.ArchivId)
                    .HasName("PK_Sys_Bool");

                entity.ToTable("Dyn_Archive");

                entity.Property(e => e.ArchivId)
                    .HasColumnName("Archiv_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArchivBezeichnung)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DynAufenthalt>(entity =>
            {
                entity.HasKey(e => e.AufenthaltId)
                    .HasName("PK__Dyn_Aufenthalt");

                entity.ToTable("Dyn_Aufenthalt");

                entity.HasIndex(e => e.AufenthaltNr);

                entity.HasIndex(e => e.Aufnahmedatum);

                entity.HasIndex(e => e.Entlassungsdatum);

                entity.HasIndex(e => e.HausId);

                entity.HasIndex(e => e.PatientId);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.AufenthaltNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.AufnahmedatumD).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.EntlassungsdatumD).HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.KorrekturEl).HasColumnName("KorrekturEL");

                entity.Property(e => e.Notiz)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.SperrDatum).HasColumnType("datetime");

                entity.HasOne(d => d.Haus)
                    .WithMany(p => p.DynAufenthalt)
                    .HasForeignKey(d => d.HausId)
                    .HasConstraintName("FK_Dyn_Aufenthalt1_8_Dyn_Haus");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DynAufenthalt)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Dyn_Aufenthalt1_8_Dyn_Patient");
            });

            modelBuilder.Entity<DynAufenthaltsTyp>(entity =>
            {
                entity.HasKey(e => e.AufenthaltsTypId);

                entity.ToTable("Dyn_AufenthaltsTyp");

                entity.HasIndex(e => e.Bezeichnung);

                entity.HasIndex(e => e.Hl7name);

                entity.HasIndex(e => e.KurzBezeichnung);

                entity.Property(e => e.AufenthaltsTypId).HasColumnName("AufenthaltsTyp_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7name)
                    .HasColumnName("HL7Name")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KurzBezeichnung)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DynAusleiheUserFachabteilung>(entity =>
            {
                entity.HasKey(e => e.AusleiheUserFachabteilungId);

                entity.ToTable("Dyn_AusleiheUserFachabteilung");

                entity.Property(e => e.AusleiheUserFachabteilungId).HasColumnName("AusleiheUserFachabteilung_ID");

                entity.Property(e => e.FachabteilungId).HasColumnName("Fachabteilung_ID");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.UserNumber).HasColumnName("User_Number");

                entity.HasOne(d => d.Fachabteilung)
                    .WithMany(p => p.DynAusleiheUserFachabteilung)
                    .HasForeignKey(d => d.FachabteilungId)
                    .HasConstraintName("FK_Dyn_AusleiheUserFachabteilung_Dyn_Fachabteilung");

                entity.HasOne(d => d.Haus)
                    .WithMany(p => p.DynAusleiheUserFachabteilung)
                    .HasForeignKey(d => d.HausId)
                    .HasConstraintName("FK_Dyn_AusleiheUserFachabteilung_Dyn_Haus");
            });

            modelBuilder.Entity<DynBeleg>(entity =>
            {
                entity.HasKey(e => e.BelegId);

                entity.ToTable("Dyn_Beleg");

                entity.HasIndex(e => e.Ablagecode);

                entity.HasIndex(e => e.AblagecodeRollfilm);

                entity.HasIndex(e => e.AktenaufenthaltId);

                entity.HasIndex(e => e.BelegFormatId);

                entity.HasIndex(e => e.BelegId)
                    .HasName("IX_Dyn_Beleg_1");

                entity.HasIndex(e => e.BelegTypId);

                entity.HasIndex(e => e.Bezeichnung);

                entity.HasIndex(e => e.DokumenttypId);

                entity.HasIndex(e => e.EreignisId);

                entity.HasIndex(e => e.ErfassungsMitarbeiterId);

                entity.HasIndex(e => e.Erfassungsdatum);

                entity.HasIndex(e => e.IstEinzelbeleg);

                entity.HasIndex(e => e.MdmAvailabilityStatusId);

                entity.HasIndex(e => e.MdmCompletionStatusId);

                entity.HasIndex(e => e.MdmConfidentialityStatusId);

                entity.HasIndex(e => e.MdmUniqueDocumentNumber);

                entity.HasIndex(e => e.PapierAktenStatusId);

                entity.HasIndex(e => e.Referenz);

                entity.HasIndex(e => e.SignaturNr);

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.Ablagecode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AblagecodeDigital)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AblagecodeRollfilm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.ArchivId).HasColumnName("Archiv_ID");

                entity.Property(e => e.BackupAktenaufenthaltId).HasColumnName("Backup_Aktenaufenthalt_ID");

                entity.Property(e => e.BelegFormatId).HasColumnName("BelegFormat_ID");

                entity.Property(e => e.BelegTypBeschreibung)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.BelegTypVollstaendigerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.BesitzMitarbeiterId).HasColumnName("BesitzMitarbeiter_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Bild).HasColumnType("image");

                entity.Property(e => e.DokumenttypId).HasColumnName("Dokumenttyp_ID");

                entity.Property(e => e.EncryptKeyId).HasColumnName("EncryptKey_ID");

                entity.Property(e => e.EreignisId).HasColumnName("Ereignis_ID");

                entity.Property(e => e.ErfassungAuto)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErfassungsMitarbeiterId).HasColumnName("ErfassungsMitarbeiter_ID");

                entity.Property(e => e.Erfassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.IsVersion).HasColumnName("isVersion");

                entity.Property(e => e.MdmAvailabilityStatusId).HasColumnName("Mdm_AvailabilityStatusId");

                entity.Property(e => e.MdmCompletionStatusId).HasColumnName("Mdm_CompletionStatusId");

                entity.Property(e => e.MdmConfidentialityStatusId).HasColumnName("Mdm_ConfidentialityStatusId");

                entity.Property(e => e.MdmParentDocumentNumber)
                    .HasColumnName("Mdm_ParentDocumentNumber")
                    .HasMaxLength(500);

                entity.Property(e => e.MdmUniqueDocumentNumber)
                    .HasColumnName("Mdm_UniqueDocumentNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.Notiz)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OberBelegId).HasColumnName("OberBeleg_ID");

                entity.Property(e => e.OcrText).IsUnicode(false);

                entity.Property(e => e.PapierAktenStatusId).HasColumnName("PapierAktenStatus_ID");

                entity.Property(e => e.Referenz)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterId).HasColumnName("Register_ID");

                entity.Property(e => e.VersionControl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VertragId).HasColumnName("Vertrag_ID");

                entity.Property(e => e.VerweisGuid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Aktenaufenthalt)
                    .WithMany(p => p.DynBeleg)
                    .HasForeignKey(d => d.AktenaufenthaltId)
                    .HasConstraintName("FK_Dyn_Beleg1_8_Arc_Aktenaufenthalt");

                entity.HasOne(d => d.Archiv)
                    .WithMany(p => p.DynBeleg)
                    .HasForeignKey(d => d.ArchivId)
                    .HasConstraintName("FK_Dyn_Beleg1_8_Dyn_Archive");

                entity.HasOne(d => d.BelegTyp)
                    .WithMany(p => p.DynBeleg)
                    .HasForeignKey(d => d.BelegTypId)
                    .HasConstraintName("FK_Dyn_Beleg_Sys_BelegTyp");

                entity.HasOne(d => d.Dokumenttyp)
                    .WithMany(p => p.DynBeleg)
                    .HasForeignKey(d => d.DokumenttypId)
                    .HasConstraintName("FK_Dyn_Beleg_Dyn_Dokumenttyp");

                entity.HasOne(d => d.MdmAvailabilityStatus)
                    .WithMany(p => p.DynBeleg)
                    .HasForeignKey(d => d.MdmAvailabilityStatusId)
                    .HasConstraintName("FK_Dyn_Beleg1_8_Dyn_MdmAvailabilityStatus");

                entity.HasOne(d => d.MdmCompletionStatus)
                    .WithMany(p => p.DynBeleg)
                    .HasForeignKey(d => d.MdmCompletionStatusId)
                    .HasConstraintName("FK_Dyn_Beleg1_8_Dyn_MdmCompletionStatus");

                entity.HasOne(d => d.MdmConfidentialityStatus)
                    .WithMany(p => p.DynBeleg)
                    .HasForeignKey(d => d.MdmConfidentialityStatusId)
                    .HasConstraintName("FK_Dyn_Beleg1_8_Dyn_MdmConfidentialityStatus");

                entity.HasOne(d => d.OberBeleg)
                    .WithMany(p => p.InverseOberBeleg)
                    .HasForeignKey(d => d.OberBelegId)
                    .HasConstraintName("FK_Dyn_Beleg1_8_Dyn_Beleg1_8");

                entity.HasOne(d => d.Register)
                    .WithMany(p => p.DynBeleg)
                    .HasForeignKey(d => d.RegisterId)
                    .HasConstraintName("FK_Dyn_Beleg_Dyn_Register");
            });

            modelBuilder.Entity<DynBelegProperties>(entity =>
            {
                entity.HasKey(e => new { e.BelegId, e.BenutzerId, e.AblagePfad, e.PropertyKey });

                entity.ToTable("Dyn_BelegProperties");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.AblagePfad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyKey)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyValue).IsUnicode(false);
            });

            modelBuilder.Entity<DynBelegSeiten>(entity =>
            {
                entity.HasKey(e => e.BelegSeitenId);

                entity.ToTable("Dyn_BelegSeiten");

                entity.Property(e => e.BelegSeitenId).HasColumnName("BelegSeiten_Id");

                entity.Property(e => e.Ablage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BelegId).HasColumnName("Beleg_Id");

                entity.Property(e => e.Benutzer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Erfassung).HasColumnType("datetime");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.DynBelegSeiten)
                    .HasForeignKey(d => d.BelegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dyn_BelegSeiten_Dyn_Beleg");
            });

            modelBuilder.Entity<DynDokumentStrukturtyp>(entity =>
            {
                entity.HasKey(e => e.DokumentStrukturtypId);

                entity.ToTable("Dyn_DokumentStrukturtyp");

                entity.Property(e => e.DokumentStrukturtypId).HasColumnName("DokumentStrukturtyp_Id");

                entity.Property(e => e.DokumenttypId).HasColumnName("Dokumenttyp_Id");

                entity.Property(e => e.StrukturId).HasColumnName("Struktur_Id");
            });

            modelBuilder.Entity<DynDokumenttyp>(entity =>
            {
                entity.HasKey(e => e.DokumenttypId);

                entity.ToTable("Dyn_Dokumenttyp");

                entity.HasIndex(e => e.BelegtypId);

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("UIX_Dyn_Dokumenttyp_Bezeichnung")
                    .IsUnique();

                entity.Property(e => e.DokumenttypId).HasColumnName("Dokumenttyp_ID");

                entity.Property(e => e.BelegtypId).HasColumnName("Belegtyp_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Belegtyp)
                    .WithMany(p => p.DynDokumenttyp)
                    .HasForeignKey(d => d.BelegtypId)
                    .HasConstraintName("FK_Dyn_Dokumenttyp_Sys_BelegTyp");
            });

            modelBuilder.Entity<DynDokumenttypMatching>(entity =>
            {
                entity.HasKey(e => e.DokumenttypMatchingId);

                entity.ToTable("Dyn_DokumenttypMatching");

                entity.HasIndex(e => e.DokumenttypId);

                entity.Property(e => e.DokumenttypMatchingId).HasColumnName("DokumenttypMatching_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DokumenttypId).HasColumnName("Dokumenttyp_ID");

                entity.Property(e => e.Matching)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegEx)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dokumenttyp)
                    .WithMany(p => p.DynDokumenttypMatching)
                    .HasForeignKey(d => d.DokumenttypId)
                    .HasConstraintName("FK_Dyn_DokumenttypMatching_Dyn_Dokumenttyp");
            });

            modelBuilder.Entity<DynFachabteilung>(entity =>
            {
                entity.HasKey(e => e.FachabteilungId);

                entity.ToTable("Dyn_Fachabteilung");

                entity.HasIndex(e => e.Aktiv);

                entity.HasIndex(e => e.HausId);

                entity.HasIndex(e => e.Kisid);

                entity.HasIndex(e => e.KurzBezeichnung);

                entity.Property(e => e.FachabteilungId).HasColumnName("Fachabteilung_ID");

                entity.Property(e => e.Bezeichnung).HasMaxLength(50);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.Kisid).HasColumnName("KISID");

                entity.Property(e => e.KurzBezeichnung).HasMaxLength(50);

                entity.Property(e => e.StandortId).HasColumnName("Standort_ID");

                entity.HasOne(d => d.Haus)
                    .WithMany(p => p.DynFachabteilung)
                    .HasForeignKey(d => d.HausId)
                    .HasConstraintName("FK_Dyn_Fachabteilung_Dyn_Haus");

                entity.HasOne(d => d.Standort)
                    .WithMany(p => p.DynFachabteilung)
                    .HasForeignKey(d => d.StandortId)
                    .HasConstraintName("FK_Dyn_Fachabteilung_Dyn_Standort");
            });

            modelBuilder.Entity<DynHaus>(entity =>
            {
                entity.HasKey(e => e.HausId);

                entity.ToTable("Dyn_Haus");

                entity.HasIndex(e => e.Bezeichnung);

                entity.HasIndex(e => e.Hl7name);

                entity.HasIndex(e => e.KurzBezeichnung);

                entity.Property(e => e.HausId)
                    .HasColumnName("Haus_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7name)
                    .HasColumnName("HL7Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KurzBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerlegerStruktur).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DynMdmAvailabilityStatus>(entity =>
            {
                entity.ToTable("Dyn_MdmAvailabilityStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LongValue)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ShortValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DynMdmCompletionStatus>(entity =>
            {
                entity.ToTable("Dyn_MdmCompletionStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LongValue)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ShortValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DynMdmConfidentialityStatus>(entity =>
            {
                entity.ToTable("Dyn_MdmConfidentialityStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LongValue)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ShortValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DynPatient>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.ToTable("Dyn_Patient");

                entity.HasIndex(e => e.Geburtsdatum);

                entity.HasIndex(e => e.Geburtsname);

                entity.HasIndex(e => e.Nachname)
                    .HasName("IX_Dyn_Patient");

                entity.HasIndex(e => e.PatientenNr);

                entity.HasIndex(e => e.Vorname);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.Bundesland).HasMaxLength(50);

                entity.Property(e => e.Geburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.Geburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Geschlecht).HasMaxLength(50);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.Land).HasMaxLength(50);

                entity.Property(e => e.Nachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ort).HasMaxLength(50);

                entity.Property(e => e.PatientenNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plz).HasMaxLength(50);

                entity.Property(e => e.Strasse).HasMaxLength(50);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Zusatz).HasMaxLength(50);
            });

            modelBuilder.Entity<DynRegister>(entity =>
            {
                entity.HasKey(e => e.RegisterId);

                entity.ToTable("Dyn_Register");

                entity.Property(e => e.RegisterId).HasColumnName("Register_ID");

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Ordnungsziffer)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterTypId).HasColumnName("RegisterTyp_ID");

                entity.HasOne(d => d.Aktenaufenthalt)
                    .WithMany(p => p.DynRegister)
                    .HasForeignKey(d => d.AktenaufenthaltId)
                    .HasConstraintName("FK_Dyn_Register_Arc_Aktenaufenthalt");

                entity.HasOne(d => d.RegisterTyp)
                    .WithMany(p => p.DynRegister)
                    .HasForeignKey(d => d.RegisterTypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dyn_Register_Dyn_RegisterTyp");
            });

            modelBuilder.Entity<DynRegisterTyp>(entity =>
            {
                entity.HasKey(e => e.RegisterTypId);

                entity.ToTable("Dyn_RegisterTyp");

                entity.Property(e => e.RegisterTypId).HasColumnName("RegisterTyp_ID");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Notiz).HasMaxLength(255);
            });

            modelBuilder.Entity<DynStandort>(entity =>
            {
                entity.HasKey(e => e.StandortId);

                entity.ToTable("Dyn_Standort");

                entity.HasIndex(e => new { e.Bezeichnung, e.KurzBezeichnung })
                    .HasName("UIX_Dyn_Standort_Bezeichnung_KurzBezeichnung")
                    .IsUnique();

                entity.Property(e => e.StandortId).HasColumnName("Standort_ID");

                entity.Property(e => e.Bezeichnung).HasMaxLength(50);

                entity.Property(e => e.KurzBezeichnung).HasMaxLength(50);
            });

            modelBuilder.Entity<DynStation>(entity =>
            {
                entity.HasKey(e => e.StationId);

                entity.ToTable("Dyn_Station");

                entity.HasIndex(e => e.Bezeichnung);

                entity.HasIndex(e => e.HausId);

                entity.HasIndex(e => e.Kisid);

                entity.HasIndex(e => e.KurzBezeichnung);

                entity.Property(e => e.StationId).HasColumnName("Station_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FachabteilungId).HasColumnName("Fachabteilung_ID");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.Kisid).HasColumnName("KISID");

                entity.Property(e => e.KurzBezeichnung).HasMaxLength(50);

                entity.HasOne(d => d.Fachabteilung)
                    .WithMany(p => p.DynStation)
                    .HasForeignKey(d => d.FachabteilungId)
                    .HasConstraintName("FK_Dyn_Station_Dyn_Fachabteilung");
            });

            modelBuilder.Entity<DynStruktur>(entity =>
            {
                entity.HasKey(e => e.StrukturId)
                    .HasName("PK_Sys_Struktur");

                entity.ToTable("Dyn_Struktur");

                entity.Property(e => e.StrukturId).HasColumnName("struktur_Id");

                entity.Property(e => e.Anmerkung)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BaumId).HasColumnName("Baum_Id");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OberStrukturId).HasColumnName("OberStruktur_Id");
            });

            modelBuilder.Entity<DynTeilBeleg>(entity =>
            {
                entity.HasKey(e => e.TeilBelegId);

                entity.ToTable("Dyn_TeilBeleg");

                entity.HasIndex(e => e.AkteId);

                entity.HasIndex(e => e.BarcodeId);

                entity.HasIndex(e => e.LfdNr);

                entity.HasIndex(e => e.PapieraktenStatusId);

                entity.Property(e => e.TeilBelegId).HasColumnName("TeilBeleg_ID");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.BarcodeId)
                    .HasColumnName("BarcodeID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.Notiz)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PapieraktenStatusId).HasColumnName("PapieraktenStatus_ID");

                entity.HasOne(d => d.Akte)
                    .WithMany(p => p.DynTeilBeleg)
                    .HasForeignKey(d => d.AkteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dyn_TeilBeleg_Arc_Akte");

                entity.HasOne(d => d.BelegTyp)
                    .WithMany(p => p.DynTeilBeleg)
                    .HasForeignKey(d => d.BelegTypId)
                    .HasConstraintName("FK_Dyn_TeilBeleg_Sys_BelegTyp");

                entity.HasOne(d => d.PapieraktenStatus)
                    .WithMany(p => p.DynTeilBeleg)
                    .HasForeignKey(d => d.PapieraktenStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dyn_TeilBeleg_Arc_PapieraktenStatus");
            });

            modelBuilder.Entity<GpBelegRechte>(entity =>
            {
                entity.HasKey(e => new { e.BelegGuid, e.FuerBenutzerId });

                entity.ToTable("Gp_BelegRechte");

                entity.HasIndex(e => e.BelegGuid);

                entity.HasIndex(e => e.BenutzerId);

                entity.HasIndex(e => e.FuerBenutzerId);

                entity.Property(e => e.FuerBenutzerId).HasColumnName("FuerBenutzer_ID");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.HasOne(d => d.FuerBenutzer)
                    .WithMany(p => p.GpBelegRechte)
                    .HasForeignKey(d => d.FuerBenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gp_BelegRechte_Sys_Benutzer");
            });

            modelBuilder.Entity<GpBelegVerweis>(entity =>
            {
                entity.HasKey(e => e.BelegVerweisId);

                entity.ToTable("Gp_BelegVerweis");

                entity.HasIndex(e => e.BelegGuid);

                entity.HasIndex(e => e.BenutzerId);

                entity.HasIndex(e => e.EbeneId);

                entity.HasIndex(e => e.VerweisGuid);

                entity.Property(e => e.BelegVerweisId).HasColumnName("BelegVerweis_ID");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.EbeneId).HasColumnName("Ebene_ID");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.GpBelegVerweis)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gp_BelegVerweis_Sys_Benutzer");
            });

            modelBuilder.Entity<LieLieferung>(entity =>
            {
                entity.HasKey(e => e.LieferungId);

                entity.ToTable("Lie_Lieferung");

                entity.HasIndex(e => e.HausId);

                entity.HasIndex(e => e.LieferungDatum);

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.LieferungDatum).HasColumnType("datetime");

                entity.HasOne(d => d.Haus)
                    .WithMany(p => p.LieLieferung)
                    .HasForeignKey(d => d.HausId)
                    .HasConstraintName("FK_Lie_Lieferung_Dyn_Haus");
            });

            modelBuilder.Entity<LiePaket>(entity =>
            {
                entity.HasKey(e => e.PaketId);

                entity.ToTable("Lie_Paket");

                entity.HasIndex(e => e.LieferungId);

                entity.HasIndex(e => e.PaketNummer);

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.ArchivId).HasColumnName("Archiv_ID");

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.PaketNummer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Archiv)
                    .WithMany(p => p.LiePaket)
                    .HasForeignKey(d => d.ArchivId)
                    .HasConstraintName("FK_Lie_Paket_Arc_Archiv");

                entity.HasOne(d => d.Lieferung)
                    .WithMany(p => p.LiePaket)
                    .HasForeignKey(d => d.LieferungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lie_Paket_Lie_Lieferung");
            });

            modelBuilder.Entity<LiePaketAkte>(entity =>
            {
                entity.HasKey(e => e.PaketAkteId);

                entity.ToTable("Lie_PaketAkte");

                entity.HasIndex(e => e.AkteId);

                entity.HasIndex(e => e.PaketId);

                entity.HasIndex(e => e.TeilBelegId);

                entity.HasIndex(e => new { e.PaketId, e.AkteId, e.TeilBelegId })
                    .HasName("UIX_Lie_PaketAkte");

                entity.Property(e => e.PaketAkteId).HasColumnName("PaketAkte_ID");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.Bemerkung).HasMaxLength(4000);

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.TeilBelegId).HasColumnName("TeilBeleg_ID");

                entity.HasOne(d => d.Akte)
                    .WithMany(p => p.LiePaketAkte)
                    .HasForeignKey(d => d.AkteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lie_PaketAkte_Arc_Akte");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.LiePaketAkte)
                    .HasForeignKey(d => d.PaketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lie_PaketAkte_Lie_Paket");
            });

            modelBuilder.Entity<ManuellerLieferbericht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ManuellerLieferbericht");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.Expr1).HasMaxLength(50);

                entity.Property(e => e.Geburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.Geburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.Nachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientenNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OcrQueuedImage>(entity =>
            {
                entity.HasKey(e => e.OcrQueueId);

                entity.ToTable("Ocr_QueuedImage");

                entity.HasIndex(e => e.ProcessedTime)
                    .HasName("IX_Ocr_Queue_ProcessedTime");

                entity.Property(e => e.OcrQueueId).HasColumnName("OcrQueue_ID");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.EnqueuedTime).HasColumnType("datetime");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.Property(e => e.ProcessedTime).HasColumnType("datetime");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.OcrQueuedImage)
                    .HasForeignKey(d => d.BelegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OcrQueue_Dyn_Beleg");
            });

            modelBuilder.Entity<OcrResult>(entity =>
            {
                entity.ToTable("Ocr_Result");

                entity.HasIndex(e => new { e.BelegId, e.Page })
                    .HasName("IX_Ocr_Result_BelegID_Page")
                    .IsUnique();

                entity.Property(e => e.OcrResultId).HasColumnName("OcrResult_ID");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.OcrTime).HasColumnType("datetime");

                entity.HasOne(d => d.Beleg)
                    .WithMany(p => p.OcrResult)
                    .HasForeignKey(d => d.BelegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OcrResult_Dyn_Beleg");
            });

            modelBuilder.Entity<Oidbex3>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Col001)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col002)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col003)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col004)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col005)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col006)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col007)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col008)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col009)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col010)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col011)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col012)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col013)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col014)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col015)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col016)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col017)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col018)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col019)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col020)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col021)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col022)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col023)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col024)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col025)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col026)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col027)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col028)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col029)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col030)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col031)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col032)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col033)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Col034)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaketVerwaltung>(entity =>
            {
                entity.HasIndex(e => e.FilmNr);

                entity.HasIndex(e => e.LagerOrt);

                entity.HasIndex(e => e.PaketNr);

                entity.Property(e => e.PaketVerwaltungId).HasColumnName("PaketVerwaltung_ID");

                entity.Property(e => e.GebDatum).HasColumnType("datetime");

                entity.Property(e => e.LagerOrt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysBelegTyp>(entity =>
            {
                entity.HasKey(e => e.BelegTypId);

                entity.ToTable("Sys_BelegTyp");

                entity.HasIndex(e => e.RegisterId);

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.AnzeigeAufenthalt).HasDefaultValueSql("((1))");

                entity.Property(e => e.AnzeigePatient).HasDefaultValueSql("((1))");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IconAktivId).HasColumnName("IconAktiv_ID");

                entity.Property(e => e.IconGeschlossenId).HasColumnName("IconGeschlossen_ID");

                entity.Property(e => e.IconOffenId).HasColumnName("IconOffen_ID");

                entity.Property(e => e.RegisterId).HasColumnName("Register_ID");

                entity.Property(e => e.SendMdm).HasColumnName("Send_MDM");

                entity.HasOne(d => d.Register)
                    .WithMany(p => p.SysBelegTyp)
                    .HasForeignKey(d => d.RegisterId)
                    .HasConstraintName("FK_Sys_BelegTyp_Dyn_Register");
            });

            modelBuilder.Entity<SysBelegTypBarcode>(entity =>
            {
                entity.HasKey(e => e.BelegTypBarcodeId);

                entity.ToTable("Sys_BelegTypBarcode");

                entity.HasIndex(e => e.BarcodeTyp);

                entity.HasIndex(e => e.BelegTypId);

                entity.Property(e => e.BelegTypBarcodeId).HasColumnName("BelegTypBarcode_ID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.FormularName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BelegTyp)
                    .WithMany(p => p.SysBelegTypBarcode)
                    .HasForeignKey(d => d.BelegTypId)
                    .HasConstraintName("FK_Sys_BelegTypBarcode_Sys_BelegTyp");
            });

            modelBuilder.Entity<SysBenutzer>(entity =>
            {
                entity.HasKey(e => e.BenutzerId);

                entity.ToTable("Sys_Benutzer");

                entity.Property(e => e.BenutzerId)
                    .HasColumnName("Benutzer_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PersonId).HasColumnName("Person_ID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SysBenutzer)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Sys_Benutzer_Sys_Mitarbeiter");
            });

            modelBuilder.Entity<SysBenutzerGruppe>(entity =>
            {
                entity.HasKey(e => new { e.BenutzerId, e.GruppeId });

                entity.ToTable("Sys_BenutzerGruppe");

                entity.HasIndex(e => e.BenutzerId);

                entity.HasIndex(e => e.GruppeId);

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.GruppeId).HasColumnName("Gruppe_ID");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.SysBenutzerGruppeBenutzer)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sys_BenutzerGruppe_Sys_Benutzer");

                entity.HasOne(d => d.Gruppe)
                    .WithMany(p => p.SysBenutzerGruppeGruppe)
                    .HasForeignKey(d => d.GruppeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sys_BenutzerGruppe_Sys_Benutzer1");
            });

            modelBuilder.Entity<SysBurnWishListItems>(entity =>
            {
                entity.HasKey(e => e.WishListItemId);

                entity.ToTable("Sys_BurnWishListItems");

                entity.Property(e => e.WishListItemId).HasColumnName("WishListItem_ID");

                entity.Property(e => e.AblagePfad)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.WishListId).HasColumnName("WishList_ID");

                entity.Property(e => e._1)
                    .HasColumnName("1")
                    .HasMaxLength(50);

                entity.Property(e => e._10)
                    .HasColumnName("10")
                    .HasMaxLength(50);

                entity.Property(e => e._11)
                    .HasColumnName("11")
                    .HasMaxLength(50);

                entity.Property(e => e._12)
                    .HasColumnName("12")
                    .HasMaxLength(50);

                entity.Property(e => e._13)
                    .HasColumnName("13")
                    .HasMaxLength(50);

                entity.Property(e => e._14)
                    .HasColumnName("14")
                    .HasMaxLength(50);

                entity.Property(e => e._15)
                    .HasColumnName("15")
                    .HasMaxLength(50);

                entity.Property(e => e._16)
                    .HasColumnName("16")
                    .HasMaxLength(50);

                entity.Property(e => e._17)
                    .HasColumnName("17")
                    .HasMaxLength(50);

                entity.Property(e => e._18)
                    .HasColumnName("18")
                    .HasMaxLength(50);

                entity.Property(e => e._19)
                    .HasColumnName("19")
                    .HasMaxLength(50);

                entity.Property(e => e._2)
                    .HasColumnName("2")
                    .HasMaxLength(50);

                entity.Property(e => e._20)
                    .HasColumnName("20")
                    .HasMaxLength(50);

                entity.Property(e => e._21)
                    .HasColumnName("21")
                    .HasMaxLength(50);

                entity.Property(e => e._22)
                    .HasColumnName("22")
                    .HasMaxLength(50);

                entity.Property(e => e._23)
                    .HasColumnName("23")
                    .HasMaxLength(50);

                entity.Property(e => e._24)
                    .HasColumnName("24")
                    .HasMaxLength(50);

                entity.Property(e => e._25)
                    .HasColumnName("25")
                    .HasMaxLength(50);

                entity.Property(e => e._26)
                    .HasColumnName("26")
                    .HasMaxLength(50);

                entity.Property(e => e._27)
                    .HasColumnName("27")
                    .HasMaxLength(50);

                entity.Property(e => e._28)
                    .HasColumnName("28")
                    .HasMaxLength(50);

                entity.Property(e => e._3)
                    .HasColumnName("3")
                    .HasMaxLength(50);

                entity.Property(e => e._4)
                    .HasColumnName("4")
                    .HasMaxLength(50);

                entity.Property(e => e._5)
                    .HasColumnName("5")
                    .HasMaxLength(50);

                entity.Property(e => e._6)
                    .HasColumnName("6")
                    .HasMaxLength(50);

                entity.Property(e => e._7)
                    .HasColumnName("7")
                    .HasMaxLength(50);

                entity.Property(e => e._8)
                    .HasColumnName("8")
                    .HasMaxLength(50);

                entity.Property(e => e._9)
                    .HasColumnName("9")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysEncryptKey>(entity =>
            {
                entity.HasKey(e => e.EncryptKeyId)
                    .HasName("PK__Sys_Encr__D8A0CE62353838AA");

                entity.ToTable("Sys_EncryptKey");

                entity.Property(e => e.EncryptKeyId)
                    .HasColumnName("EncryptKey_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EncryptKey).IsRequired();

                entity.Property(e => e.Iv)
                    .IsRequired()
                    .HasColumnName("IV")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SysEreignisTyp>(entity =>
            {
                entity.HasKey(e => e.EreignisTypId)
                    .HasName("PK_Arc_EreignisTyp");

                entity.ToTable("Sys_EreignisTyp");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("UIX_Arc_EreignisTyp_Bezeichnung")
                    .IsUnique();

                entity.Property(e => e.EreignisTypId)
                    .HasColumnName("EreignisTyp_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notiz).HasColumnType("ntext");
            });

            modelBuilder.Entity<SysEreignisgrund>(entity =>
            {
                entity.HasKey(e => e.EreignisgrundId);

                entity.ToTable("Sys_Ereignisgrund");

                entity.Property(e => e.EreignisgrundId).HasColumnName("Ereignisgrund_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisTypId).HasColumnName("EreignisTyp_ID");

                entity.Property(e => e.Notiz).HasColumnType("ntext");

                entity.HasOne(d => d.EreignisTyp)
                    .WithMany(p => p.SysEreignisgrund)
                    .HasForeignKey(d => d.EreignisTypId)
                    .HasConstraintName("FK_Sys_Ereignisgrund_Arc_EreignisTyp");
            });

            modelBuilder.Entity<SysErledigunsart>(entity =>
            {
                entity.HasKey(e => e.ErledigunsartId)
                    .HasName("PK_Arc_Erledigunsart");

                entity.ToTable("Sys_Erledigunsart");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("UIX_Arc_Erledigunsart_Bezeichnung")
                    .IsUnique();

                entity.HasIndex(e => e.EreignisTypId)
                    .HasName("IX_Arc_Erledigunsart_EreignisTyp_ID");

                entity.Property(e => e.ErledigunsartId)
                    .HasColumnName("Erledigunsart_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisTypId).HasColumnName("EreignisTyp_ID");

                entity.HasOne(d => d.EreignisTyp)
                    .WithMany(p => p.SysErledigunsart)
                    .HasForeignKey(d => d.EreignisTypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Arc_Erledigunsart_Arc_EreignisTyp");
            });

            modelBuilder.Entity<SysFrontendLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sys_FrontendLog");

                entity.HasIndex(e => e.BenutzerId);

                entity.HasIndex(e => e.DatumUhrzeit);

                entity.Property(e => e.Aktion).HasColumnType("text");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.DatumUhrzeit).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Benutzer)
                    .WithMany()
                    .HasForeignKey(d => d.BenutzerId)
                    .HasConstraintName("FK_Sys_FrontendLog_Sys_Benutzer");
            });

            modelBuilder.Entity<SysIcon>(entity =>
            {
                entity.HasKey(e => e.IconId);

                entity.ToTable("Sys_Icon");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("UIX_Sys_Icon_Bezeichnung")
                    .IsUnique();

                entity.Property(e => e.IconId)
                    .HasColumnName("Icon_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Groß)
                    .HasColumnName("groß")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Klein)
                    .HasColumnName("klein")
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Mittel)
                    .HasColumnName("mittel")
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SysMahnstufe>(entity =>
            {
                entity.HasKey(e => e.MahnStufeId)
                    .HasName("PK_Arc_Mahnstufe");

                entity.ToTable("Sys_Mahnstufe");

                entity.HasIndex(e => e.EreignisTypId)
                    .HasName("IX_Arc_Mahnstufe_EreignisTyp_ID");

                entity.HasIndex(e => e.MahnStufeId)
                    .HasName("IX_Arc_Mahnstufe");

                entity.HasIndex(e => new { e.EreignisTypId, e.Stufe })
                    .HasName("UIX_Sys_Mahnstufe")
                    .IsUnique();

                entity.Property(e => e.MahnStufeId).HasColumnName("MahnStufe_ID");

                entity.Property(e => e.EreignisTypId).HasColumnName("EreignisTyp_ID");

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.HasOne(d => d.EreignisTyp)
                    .WithMany(p => p.SysMahnstufe)
                    .HasForeignKey(d => d.EreignisTypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Arc_Mahnstufe_Arc_EreignisTyp");
            });

            modelBuilder.Entity<SysMitarbeiter>(entity =>
            {
                entity.HasKey(e => e.MitarbeiterId);

                entity.ToTable("Sys_Mitarbeiter");

                entity.HasIndex(e => e.KisId);

                entity.HasIndex(e => e.Nachname);

                entity.HasIndex(e => e.Vorname);

                entity.Property(e => e.MitarbeiterId).HasColumnName("Mitarbeiter_ID");

                entity.Property(e => e.EmailAdresse)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Geburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.KisId).HasColumnName("Kis_ID");

                entity.Property(e => e.MitarbeiterNummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nachname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Postleitzahl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Strasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wohnort)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysRecht>(entity =>
            {
                entity.HasKey(e => e.RechtId);

                entity.ToTable("Sys_Recht");

                entity.HasIndex(e => e.BenutzerId);

                entity.HasIndex(e => e.Druck);

                entity.HasIndex(e => e.EbeneId);

                entity.HasIndex(e => e.Id);

                entity.HasIndex(e => e.Sicht)
                    .HasName("IX_Sys_Recht_sicht");

                entity.Property(e => e.RechtId).HasColumnName("Recht_ID");

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.EbeneId).HasColumnName("Ebene_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Benutzer)
                    .WithMany(p => p.SysRecht)
                    .HasForeignKey(d => d.BenutzerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sys_Recht_Sys_Benutzer");
            });

            modelBuilder.Entity<VAkteAngefordert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AkteAngefordert");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnfordererName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnforderungId).HasColumnName("Anforderung_ID");

                entity.Property(e => e.AnforderungsDatum).HasColumnType("smalldatetime");

                entity.Property(e => e.ArchivBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.Ausleihgrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EinzelbelegStatusId).HasColumnName("EinzelbelegStatus_ID");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.LagerEbene)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerFach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerGang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerRegal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitarbeiterId).HasColumnName("Mitarbeiter_ID");

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientNachname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAkteAufenthalt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AkteAufenthalt");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AktenAnmerkung).HasMaxLength(2000);

                entity.Property(e => e.AktenTypId).HasColumnName("AktenTyp_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.LagerOrtId).HasColumnName("LagerOrt_ID");

                entity.Property(e => e.MahnStufeId).HasColumnName("MahnStufe_ID");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.Referenz)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAkteAufenthaltKlartext>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AkteAufenthaltKlartext");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.LagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientNachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAkteVerpacken>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AkteVerpacken");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AkteVerpackenBemerkung).HasMaxLength(4000);

                entity.Property(e => e.AktenAnmerkung).HasMaxLength(2000);

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.BarcodeId)
                    .HasColumnName("BarcodeID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.FachabteilungBezeichnung).HasMaxLength(50);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.LagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lieferdatum).HasColumnType("datetime");

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.PaketNummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientNachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeilBelegBezeichnung)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TeilBelegId).HasColumnName("TeilBeleg_ID");
            });

            modelBuilder.Entity<VAktenTyp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AktenTyp");

                entity.Property(e => e.AktenTypId)
                    .HasColumnName("AktenTyp_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAktenhistorie>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Aktenhistorie");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Anmerkung).HasColumnType("ntext");

                entity.Property(e => e.ArchivBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltsTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.EreignisDatum).HasColumnType("datetime");

                entity.Property(e => e.EreignisGrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Faelligkeitsdatum).HasColumnType("datetime");

                entity.Property(e => e.FreigabeStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerEbene)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerFach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerGang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerRegal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitarbeiterNachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitarbeiterVorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PapieraktenStatus).HasMaxLength(200);

                entity.Property(e => e.VerarbeitungsstatusBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAktenhistorieErweitert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Aktenhistorie_Erweitert");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Anmerkung).HasColumnType("ntext");

                entity.Property(e => e.ArchivBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BenutzerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisDatum).HasColumnType("datetime");

                entity.Property(e => e.EreignisGrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisTag).HasColumnType("datetime");

                entity.Property(e => e.EreignisTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Faelligkeitsdatum).HasColumnType("datetime");

                entity.Property(e => e.FreigabeStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerEbene)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerFach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerGang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerRegal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitarbeiterNachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitarbeiterVorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PapieraktenStatus).HasMaxLength(200);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Verarbeitungsstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAlleVerweise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AlleVerweise");
            });

            modelBuilder.Entity<VArchivlagerort>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Archivlagerort");

                entity.Property(e => e.ArchivGuid).HasColumnName("Archiv_GUID");

                entity.Property(e => e.ArchivId)
                    .HasColumnName("Archiv_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");
            });

            modelBuilder.Entity<VArchivverwaltungStandard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Archivverwaltung_Standard");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AkteVerpackenBemerkung).HasMaxLength(4000);

                entity.Property(e => e.AktenAnmerkung).HasMaxLength(2000);

                entity.Property(e => e.AktenTypBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AktenTypId).HasColumnName("AktenTyp_ID");

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.AufenthaltsTypBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltsTypKurzBezeichnung)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.AusleihAnmerkung).HasColumnType("ntext");

                entity.Property(e => e.AusleihLagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ausleihdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Ausleihgrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.EntleiherNachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntleiherVorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FachabteilungBezeichnung).HasMaxLength(50);

                entity.Property(e => e.FachabteilungKurzBezeichnung).HasMaxLength(50);

                entity.Property(e => e.Faelligkeitsdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.HausKurzBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerEbene)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerFach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerGang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerOrtId).HasColumnName("LagerOrt_ID");

                entity.Property(e => e.LagerRegal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lieferdatum).HasColumnType("datetime");

                entity.Property(e => e.PaketNummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientNachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationKurzBezeichnung).HasMaxLength(50);
            });

            modelBuilder.Entity<VAufenthaltEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AufenthaltEbene");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.AufenthaltNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltsTypId).HasColumnName("AufenthaltsTyp_ID");

                entity.Property(e => e.Aufenthaltstyp)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.Fachabteilung).HasMaxLength(50);

                entity.Property(e => e.FachabteilungId).HasColumnName("Fachabteilung_ID");

                entity.Property(e => e.Haus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.Station)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationId).HasColumnName("Station_ID");
            });

            modelBuilder.Entity<VAusleihgrund>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Ausleihgrund");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisgrundId).HasColumnName("Ereignisgrund_ID");
            });

            modelBuilder.Entity<VAusleihlagerort>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Ausleihlagerort");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ebene)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fach)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Regal)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAusleihstatusKlartext>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AusleihstatusKlartext");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AusleihLagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ausleihdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Ausleihgrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntleiherNachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntleiherVorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Faelligkeitsdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");
            });

            modelBuilder.Entity<VAusleihverwaltungStandard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Ausleihverwaltung_Standard");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AktenAnmerkung).HasMaxLength(2000);

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.AufenthaltsTypBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltsTypKurzBezeichnung)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.AusLeihLagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AusleihAnmerkung).HasColumnType("ntext");

                entity.Property(e => e.Ausleihdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Ausleihgrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.EntleiherNachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntleiherVorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisTypId).HasColumnName("EreignisTyp_ID");

                entity.Property(e => e.FachabteilungBezeichnung).HasMaxLength(50);

                entity.Property(e => e.FachabteilungKurzBezeichnung).HasMaxLength(50);

                entity.Property(e => e.Faelligkeitsdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.HausKurzBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsdatumText)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientNachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationKurzBezeichnung).HasMaxLength(50);
            });

            modelBuilder.Entity<VAusleihverwaltungStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Ausleihverwaltung_Station");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AktenAnmerkung).HasMaxLength(2000);

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.AufenthaltsTypBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltsTypKurzBezeichnung)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.AusleihAnmerkung).HasColumnType("ntext");

                entity.Property(e => e.Ausleihdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Ausleihgrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.EntleiherNachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntleiherVorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisTypId).HasColumnName("EreignisTyp_ID");

                entity.Property(e => e.FachabteilungBezeichnung).HasMaxLength(50);

                entity.Property(e => e.Faelligkeitsdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.HausKurzBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsdatumText)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientNachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VBarcodeAufenthalt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BarcodeAufenthalt");

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientNachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VBarcodePatientAufenthalt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BarcodePatientAufenthalt");

                entity.Property(e => e.AufenthaltNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Geburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.Geburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.Nachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientenNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationId).HasColumnName("Station_ID");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VBarcodeStandard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Barcode_Standard");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasColumnName("AUfenthaltsnummer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientNachname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VBaumBelegEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BaumBelegEbene");

                entity.Property(e => e.Ablagepfad)
                    .HasMaxLength(182)
                    .IsUnicode(false);

                entity.Property(e => e.AktenAufenthaltId).HasColumnName("AktenAufenthalt_ID");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.BelegTypBeschreibung)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.BelegTypVollstaendigerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BelegtypId).HasColumnName("Belegtyp_ID");

                entity.Property(e => e.Dokumenttyp)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DokumenttypId).HasColumnName("Dokumenttyp_ID");

                entity.Property(e => e.Erfassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(285)
                    .IsUnicode(false);

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VBelegEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BelegEbene");

                entity.Property(e => e.Ablagepfad)
                    .HasMaxLength(182)
                    .IsUnicode(false);

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.BelegTypBeschreibung)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.BelegTypName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BelegTypVollstaendigerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Erfassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.NameToDisplay).HasMaxLength(285);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");
            });

            modelBuilder.Entity<VBelegTypBarcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BelegTypBarcode");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BelegTypBarcodeId).HasColumnName("BelegTypBarcode_ID");

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.Bezeichnung).IsUnicode(false);

                entity.Property(e => e.FormularName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VBelegTypEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BelegTypEbene");

                entity.Property(e => e.Ablagepfad)
                    .HasMaxLength(182)
                    .IsUnicode(false);

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.BelegTyp)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Expr2)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.NameToDisplay)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");
            });

            modelBuilder.Entity<VDokumenttyp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Dokumenttyp");

                entity.Property(e => e.BelegtypId).HasColumnName("Belegtyp_ID");

                entity.Property(e => e.Dokumenttyp)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DokumenttypId)
                    .HasColumnName("Dokumenttyp_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VDokumenttypMatching>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DokumenttypMatching");

                entity.Property(e => e.DokumenttypId).HasColumnName("Dokumenttyp_ID");

                entity.Property(e => e.DokumenttypMatching)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DokumenttypMatchingId)
                    .HasColumnName("DokumenttypMatching_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Matching)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RegEx)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VEbene2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Ebene2");

                entity.Property(e => e.AufenthaltNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum)
                    .HasColumnName("ENtlassungsdatum")
                    .HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.StationId).HasColumnName("Station_ID");

                entity.Property(e => e.Titel)
                    .HasMaxLength(342)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VFreigegebeneBelegVerweise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FreigegebeneBelegVerweise");

                entity.Property(e => e.Ablagecode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AblagecodeDigital)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AblagecodeRollfilm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.BelegFormatId).HasColumnName("BelegFormat_ID");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.BesitzMitarbeiterId).HasColumnName("BesitzMitarbeiter_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Bild).HasColumnType("image");

                entity.Property(e => e.ErfassungsMitarbeiterId).HasColumnName("ErfassungsMitarbeiter_ID");

                entity.Property(e => e.Erfassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.Notiz)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OberBelegId).HasColumnName("OberBeleg_ID");

                entity.Property(e => e.OcrText).IsUnicode(false);

                entity.Property(e => e.PapierAktenStatusId).HasColumnName("PapierAktenStatus_ID");

                entity.Property(e => e.Referenz)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLieferungAusdruck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_LieferungAusdruck");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AkteVerpackenBemerkung).HasMaxLength(4000);

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltsTyp)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.BarcodeId)
                    .HasColumnName("BarcodeID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.FachabteilungBezeichnung).HasMaxLength(50);

                entity.Property(e => e.FachabteilungKurzBezeichnung).HasMaxLength(50);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.HausKurzBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lieferdatum).HasColumnType("datetime");

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.PaketNummer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientNachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationKurzBezeichnung).HasMaxLength(50);

                entity.Property(e => e.TeilBelegBezeichnung)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLieferungStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Lieferung_Station");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AkteVerpackenBemerkung).HasMaxLength(4000);

                entity.Property(e => e.AktenAnmerkung).HasMaxLength(2000);

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.AufenthaltsTypBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltsTypKurzBezeichnung)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.BarcodeId)
                    .HasColumnName("BarcodeID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.FachabteilungBezeichnung).HasMaxLength(50);

                entity.Property(e => e.FachabteilungKurzBezeichnung).HasMaxLength(50);

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.HausKurzBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lieferdatum).HasColumnType("datetime");

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.PaketNummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientNachname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationKurzBezeichnung).HasMaxLength(50);

                entity.Property(e => e.TeilBelegBezeichnung)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TeilBelegId).HasColumnName("TeilBeleg_ID");
            });

            modelBuilder.Entity<VLieferungTeilBeleg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Lieferung_TeilBeleg");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AkteVerpackenBemerkung).HasMaxLength(4000);

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AufenthaltId).HasColumnName("Aufenthalt_ID");

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.BarcodeId)
                    .HasColumnName("BarcodeID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eingangsdatum).HasColumnType("datetime");

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.LagerortBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lieferdatum).HasColumnType("datetime");

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.PaketNummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientGeburtsname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.PatientNachname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StationBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeilBelegBezeichnung)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TeilBelegId).HasColumnName("TeilBeleg_ID");
            });

            modelBuilder.Entity<VLieferungen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Lieferungen");

                entity.Property(e => e.ArchivId).HasColumnName("Archiv_ID");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.Lieferdatum).HasColumnType("datetime");

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.PaketNummer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tbstatus)
                    .IsRequired()
                    .HasColumnName("TBStatus")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLieferungenPakete>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Lieferungen_Pakete");

                entity.Property(e => e.ArchivId).HasColumnName("Archiv_ID");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.LieferungDatum).HasColumnType("datetime");

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.PaketNummer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLieferungenPaketeCheckComplete>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Lieferungen_Pakete_CheckComplete");

                entity.Property(e => e.PaketAkteId).HasColumnName("PaketAkte_ID");

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");
            });

            modelBuilder.Entity<VNeuePakete>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_neuePakete");

                entity.Property(e => e.ArchivId).HasColumnName("Archiv_ID");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.LieferungDatum).HasColumnType("datetime");

                entity.Property(e => e.LieferungId).HasColumnName("Lieferung_ID");

                entity.Property(e => e.PaketId).HasColumnName("Paket_ID");

                entity.Property(e => e.PaketNummer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VRecht>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Recht");

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.EbeneId).HasColumnName("Ebene_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VRechtUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RechtUser");

                entity.Property(e => e.BenutzerId).HasColumnName("Benutzer_ID");

                entity.Property(e => e.EbeneId).HasColumnName("Ebene_ID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Register");

                entity.Property(e => e.Ordnungsziffer)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Register)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterId)
                    .HasColumnName("Register_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VRegisterEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RegisterEbene");

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.Register)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterId).HasColumnName("Register_ID");
            });

            modelBuilder.Entity<VRptAktenbewegung>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RPT_Aktenbewegung");

                entity.Property(e => e.Aktennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Anmerkung).HasColumnType("ntext");

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisDatum).HasColumnType("datetime");

                entity.Property(e => e.EreignisGrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EreignisTag).HasColumnType("datetime");

                entity.Property(e => e.EreignisTyp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Freigabestatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitarbeiterNachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MitarbeiterVorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PapieraktenStatus).HasMaxLength(200);

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Verarbeitungsstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VStrukturAkut>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Struktur_Akut");

                entity.Property(e => e.Bs1)
                    .HasColumnName("BS1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs2)
                    .HasColumnName("BS2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs3)
                    .HasColumnName("BS3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bsid1).HasColumnName("BSID1");

                entity.Property(e => e.Bsid2).HasColumnName("BSID2");

                entity.Property(e => e.Bsid3).HasColumnName("BSID3");

                entity.Property(e => e.Bspos1).HasColumnName("BSPos1");

                entity.Property(e => e.Bspos2).HasColumnName("BSPos2");

                entity.Property(e => e.Bspos3).HasColumnName("BSPos3");

                entity.Property(e => e.Dok)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Obsid1).HasColumnName("OBSID1");

                entity.Property(e => e.Obsid2).HasColumnName("OBSID2");

                entity.Property(e => e.Obsid3).HasColumnName("OBSID3");
            });

            modelBuilder.Entity<VStrukturAkutEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Struktur_Akut_Ebene");

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.BelegtypId).HasColumnName("Belegtyp_ID");

                entity.Property(e => e.Bs1)
                    .HasColumnName("BS1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs2)
                    .HasColumnName("BS2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs3)
                    .HasColumnName("BS3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bsid1).HasColumnName("BSID1");

                entity.Property(e => e.Bsid2).HasColumnName("BSID2");

                entity.Property(e => e.Bsid3).HasColumnName("BSID3");

                entity.Property(e => e.Bspos1).HasColumnName("BSPos1");

                entity.Property(e => e.Bspos2).HasColumnName("BSPos2");

                entity.Property(e => e.Bspos3).HasColumnName("BSPos3");

                entity.Property(e => e.Obsid1).HasColumnName("OBSID1");

                entity.Property(e => e.Obsid2).HasColumnName("OBSID2");

                entity.Property(e => e.Obsid3).HasColumnName("OBSID3");
            });

            modelBuilder.Entity<VStrukturEfa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Struktur_Efa");

                entity.Property(e => e.Bs1)
                    .HasColumnName("BS1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs2)
                    .HasColumnName("BS2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs3)
                    .HasColumnName("BS3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bsid1).HasColumnName("BSID1");

                entity.Property(e => e.Bsid2).HasColumnName("BSID2");

                entity.Property(e => e.Bsid3).HasColumnName("BSID3");

                entity.Property(e => e.Bspos1).HasColumnName("BSPos1");

                entity.Property(e => e.Bspos2).HasColumnName("BSPos2");

                entity.Property(e => e.Bspos3).HasColumnName("BSPos3");

                entity.Property(e => e.Dok)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Obsid1).HasColumnName("OBSID1");

                entity.Property(e => e.Obsid2).HasColumnName("OBSID2");

                entity.Property(e => e.Obsid3).HasColumnName("OBSID3");
            });

            modelBuilder.Entity<VStrukturEfaEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Struktur_Efa_Ebene");

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.BelegtypId).HasColumnName("Belegtyp_ID");

                entity.Property(e => e.Bs1)
                    .HasColumnName("BS1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs2)
                    .HasColumnName("BS2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs3)
                    .HasColumnName("BS3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bsid1).HasColumnName("BSID1");

                entity.Property(e => e.Bsid2).HasColumnName("BSID2");

                entity.Property(e => e.Bsid3).HasColumnName("BSID3");

                entity.Property(e => e.Bspos1).HasColumnName("BSPos1");

                entity.Property(e => e.Bspos2).HasColumnName("BSPos2");

                entity.Property(e => e.Bspos3).HasColumnName("BSPos3");

                entity.Property(e => e.Obsid1).HasColumnName("OBSID1");

                entity.Property(e => e.Obsid2).HasColumnName("OBSID2");

                entity.Property(e => e.Obsid3).HasColumnName("OBSID3");
            });

            modelBuilder.Entity<VStrukturReha>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Struktur_Reha");

                entity.Property(e => e.Bs1)
                    .HasColumnName("BS1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs2)
                    .HasColumnName("BS2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs3)
                    .HasColumnName("BS3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bsid1).HasColumnName("BSID1");

                entity.Property(e => e.Bsid2).HasColumnName("BSID2");

                entity.Property(e => e.Bsid3).HasColumnName("BSID3");

                entity.Property(e => e.Bspos1).HasColumnName("BSPos1");

                entity.Property(e => e.Bspos2).HasColumnName("BSPos2");

                entity.Property(e => e.Bspos3).HasColumnName("BSPos3");

                entity.Property(e => e.Dok)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Obsid1).HasColumnName("OBSID1");

                entity.Property(e => e.Obsid2).HasColumnName("OBSID2");

                entity.Property(e => e.Obsid3).HasColumnName("OBSID3");
            });

            modelBuilder.Entity<VStrukturRehaEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Struktur_Reha_Ebene");

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.BelegtypId).HasColumnName("Belegtyp_ID");

                entity.Property(e => e.Bs1)
                    .HasColumnName("BS1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs2)
                    .HasColumnName("BS2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bs3)
                    .HasColumnName("BS3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bsid1).HasColumnName("BSID1");

                entity.Property(e => e.Bsid2).HasColumnName("BSID2");

                entity.Property(e => e.Bsid3).HasColumnName("BSID3");

                entity.Property(e => e.Bspos1).HasColumnName("BSPos1");

                entity.Property(e => e.Bspos2).HasColumnName("BSPos2");

                entity.Property(e => e.Bspos3).HasColumnName("BSPos3");

                entity.Property(e => e.Obsid1).HasColumnName("OBSID1");

                entity.Property(e => e.Obsid2).HasColumnName("OBSID2");

                entity.Property(e => e.Obsid3).HasColumnName("OBSID3");
            });

            modelBuilder.Entity<VSysBelegEbene>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_SysBelegEbene");

                entity.Property(e => e.Ablagepfad)
                    .HasMaxLength(182)
                    .IsUnicode(false);

                entity.Property(e => e.AktenaufenthaltId).HasColumnName("Aktenaufenthalt_ID");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.BelegTypId).HasColumnName("BelegTyp_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.RegisterId).HasColumnName("Register_ID");
            });

            modelBuilder.Entity<VTeilBelege>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TeilBelege");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AufenthaltNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("datetime");

                entity.Property(e => e.BarcodeId)
                    .HasColumnName("BarcodeID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BelegTyp).IsUnicode(false);

                entity.Property(e => e.Entlassungsdatum).HasColumnType("datetime");

                entity.Property(e => e.Geburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.HausId).HasColumnName("Haus_ID");

                entity.Property(e => e.Nachname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notiz)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PapieraktenStatus).HasMaxLength(200);

                entity.Property(e => e.PapieraktenStatusId).HasColumnName("PapieraktenStatus_ID");

                entity.Property(e => e.TeilBelegId).HasColumnName("TeilBeleg_ID");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VXrayErfassen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XRayErfassen");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PatientGeburtsdatum).HasColumnType("datetime");

                entity.Property(e => e.PatientNachname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientVorname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VXrayErfassenAllow>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_XRayErfassenAllow");

                entity.Property(e => e.AkteId).HasColumnName("Akte_ID");

                entity.Property(e => e.AktenTypId).HasColumnName("AktenTyp_ID");

                entity.Property(e => e.Aufenthaltsnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("Patient_ID");

                entity.Property(e => e.Patientennummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAktionstyp>(entity =>
            {
                entity.HasKey(e => e.AktionstypId);

                entity.ToTable("Vw_Aktionstyp");

                entity.Property(e => e.AktionstypId)
                    .HasColumnName("Aktionstyp_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAktivitaet>(entity =>
            {
                entity.HasKey(e => e.AktivitaetId);

                entity.ToTable("Vw_Aktivitaet");

                entity.Property(e => e.AktivitaetId).HasColumnName("Aktivitaet_ID");

                entity.Property(e => e.AktionstypId)
                    .HasColumnName("Aktionstyp_ID")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.AktivitaetErledigungsstatusId).HasColumnName("AktivitaetErledigungsstatus_ID");

                entity.Property(e => e.BearbeiterAnlage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BearbeiterDurchfuehrung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BearbeitungsstatusId)
                    .HasColumnName("Bearbeitungsstatus_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DatumAnlage).HasColumnType("datetime");

                entity.Property(e => e.DatumBezug).HasColumnType("datetime");

                entity.Property(e => e.DatumWiedervorlage).HasColumnType("datetime");

                entity.Property(e => e.EmailGesendet).HasColumnType("datetime");

                entity.Property(e => e.EmailGesendetVon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ergebnis).IsUnicode(false);

                entity.Property(e => e.ErledigtAm).HasColumnType("datetime");

                entity.Property(e => e.Notiz).IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VorgangId).HasColumnName("Vorgang_ID");

                entity.Property(e => e.VorgangsdetailId).HasColumnName("Vorgangsdetail_ID");

                entity.Property(e => e.VorgangstypdetailId).HasColumnName("Vorgangstypdetail_ID");

                entity.HasOne(d => d.Aktionstyp)
                    .WithMany(p => p.VwAktivitaet)
                    .HasForeignKey(d => d.AktionstypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_Aktivitaet_Vw_Aktionstyp");

                entity.HasOne(d => d.AktivitaetErledigungsstatus)
                    .WithMany(p => p.VwAktivitaet)
                    .HasForeignKey(d => d.AktivitaetErledigungsstatusId)
                    .HasConstraintName("FK_Vw_Aktivitaet_Vw_AktivitaetErledigungsstatus");

                entity.HasOne(d => d.Bearbeitungsstatus)
                    .WithMany(p => p.VwAktivitaet)
                    .HasForeignKey(d => d.BearbeitungsstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_Aktivitaet_Vw_Bearbeitungsstatus");

                entity.HasOne(d => d.Vorgang)
                    .WithMany(p => p.VwAktivitaet)
                    .HasForeignKey(d => d.VorgangId)
                    .HasConstraintName("FK_Vw_Aktivitaet_Vw_Vorgang");

                entity.HasOne(d => d.Vorgangsdetail)
                    .WithMany(p => p.VwAktivitaet)
                    .HasForeignKey(d => d.VorgangsdetailId)
                    .HasConstraintName("FK_Vw_Aktivitaet_Vw_Vorgangsdetail");

                entity.HasOne(d => d.Vorgangstypdetail)
                    .WithMany(p => p.VwAktivitaet)
                    .HasForeignKey(d => d.VorgangstypdetailId)
                    .HasConstraintName("FK_Vw_Aktivitaet_Vw_Vorgangstypdetail");
            });

            modelBuilder.Entity<VwAktivitaetErledigungsstatus>(entity =>
            {
                entity.HasKey(e => e.AktivitaetErledigungsstatusId);

                entity.ToTable("Vw_AktivitaetErledigungsstatus");

                entity.Property(e => e.AktivitaetErledigungsstatusId).HasColumnName("AktivitaetErledigungsstatus_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBearbeitungsstatus>(entity =>
            {
                entity.HasKey(e => e.BearbeitungsstatusId);

                entity.ToTable("Vw_Bearbeitungsstatus");

                entity.Property(e => e.BearbeitungsstatusId)
                    .HasColumnName("Bearbeitungsstatus_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBelegverweis>(entity =>
            {
                entity.HasKey(e => e.BelegverweisId);

                entity.ToTable("Vw_Belegverweis");

                entity.Property(e => e.BelegverweisId).HasColumnName("Belegverweis_ID");

                entity.Property(e => e.AblagePfad)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AktivitaetId).HasColumnName("Aktivitaet_ID");

                entity.Property(e => e.BelegId).HasColumnName("Beleg_ID");

                entity.Property(e => e.Belegtyp)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Bild).HasColumnType("image");

                entity.Property(e => e.BildName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Aktivitaet)
                    .WithMany(p => p.VwBelegverweis)
                    .HasForeignKey(d => d.AktivitaetId)
                    .HasConstraintName("FK_Vw_Belegverweis_Vw_Aktivitaet");
            });

            modelBuilder.Entity<VwBelegverweisTyp>(entity =>
            {
                entity.HasKey(e => e.BelegverweisTypId);

                entity.ToTable("Vw_BelegverweisTyp");

                entity.Property(e => e.BelegverweisTypId).HasColumnName("BelegverweisTyp_ID");

                entity.Property(e => e.Beschreibung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBelegverweisVorgang>(entity =>
            {
                entity.HasKey(e => e.BelegverweisVorgangId)
                    .HasName("PK_BelegverweisVorgang");

                entity.ToTable("Vw_BelegverweisVorgang");

                entity.Property(e => e.AblagePfad)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BelegverweisTypId).HasColumnName("BelegverweisTyp_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Bildname)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.LastModificationUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.BelegverweisTyp)
                    .WithMany(p => p.VwBelegverweisVorgang)
                    .HasForeignKey(d => d.BelegverweisTypId)
                    .HasConstraintName("FK_Vw_BelegverweisVorgang_Vw_BelegverweisTyp");
            });

            modelBuilder.Entity<VwConfiguration>(entity =>
            {
                entity.HasKey(e => e.ConfigurationId);

                entity.ToTable("Vw_Configuration");

                entity.Property(e => e.ConfigurationId).HasColumnName("Configuration_Id");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwControl>(entity =>
            {
                entity.ToTable("Vw_Control");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwControlItem>(entity =>
            {
                entity.ToTable("Vw_Control_Item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ControlId).HasColumnName("control_id");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.VwControlItem)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_Control_Item_Vw_Control");
            });

            modelBuilder.Entity<VwEmailHistorie>(entity =>
            {
                entity.HasKey(e => e.EmailHistorieId);

                entity.ToTable("Vw_EmailHistorie");

                entity.Property(e => e.EmailHistorieId).HasColumnName("EmailHistorie_Id");

                entity.Property(e => e.Adressen)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDatum).HasColumnType("datetime");

                entity.Property(e => e.Kommentar)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Kommentarfarbe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.Property(e => e.VorgangId).HasColumnName("Vorgang_Id");

                entity.HasOne(d => d.Vorgang)
                    .WithMany(p => p.VwEmailHistorie)
                    .HasForeignKey(d => d.VorgangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_EmailHistorie_Vw_Vorgang");
            });

            modelBuilder.Entity<VwErledigungsstatus>(entity =>
            {
                entity.HasKey(e => e.ErledigungsstatusId);

                entity.ToTable("Vw_Erledigungsstatus");

                entity.Property(e => e.ErledigungsstatusId)
                    .HasColumnName("Erledigungsstatus_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwExtraPatientInformations>(entity =>
            {
                entity.ToTable("Vw_ExtraPatientInformations");

                entity.Property(e => e.AufnahmeDatum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BehandelnderArzt)
                    .HasColumnName("Behandelnder_Arzt")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EntlassungsDatum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fachbateilung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fallnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Geburtsdatum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Geschlecht)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hl7Message).IsUnicode(false);

                entity.Property(e => e.Hl7Typ)
                    .HasColumnName("HL7_Typ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nachname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patientenstatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Station)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwFelder>(entity =>
            {
                entity.ToTable("Vw_Felder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Eigenschaft)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwServiceLog>(entity =>
            {
                entity.ToTable("Vw_ServiceLog");

                entity.Property(e => e.Level).HasMaxLength(128);

                entity.Property(e => e.Properties).HasColumnType("xml");
            });

            modelBuilder.Entity<VwStandort>(entity =>
            {
                entity.HasKey(e => e.StandortId);

                entity.ToTable("Vw_Standort");

                entity.Property(e => e.StandortId).HasColumnName("standort_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwStandortUser>(entity =>
            {
                entity.HasKey(e => e.StandortUserId)
                    .HasName("PK_StandortUser");

                entity.ToTable("Vw_StandortUser");

                entity.Property(e => e.StandortUserId).HasColumnName("StandortUser_Id");

                entity.Property(e => e.StandordId).HasColumnName("Standord_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Standord)
                    .WithMany(p => p.VwStandortUser)
                    .HasForeignKey(d => d.StandordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_StandortUser_Vw_Standort");
            });

            modelBuilder.Entity<VwStatistik>(entity =>
            {
                entity.ToTable("Vw_Statistik");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwStatistikItem>(entity =>
            {
                entity.ToTable("Vw_Statistik_Item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwVorgang>(entity =>
            {
                entity.HasKey(e => e.VorgangId);

                entity.ToTable("Vw_Vorgang");

                entity.Property(e => e.VorgangId).HasColumnName("Vorgang_ID");

                entity.Property(e => e.AufenthaltBis).HasColumnType("datetime");

                entity.Property(e => e.AufenthaltVon).HasColumnType("datetime");

                entity.Property(e => e.BearbeiterAnlage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BearbeiterDurchfuehrung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BearbeitungsstatusId).HasColumnName("Bearbeitungsstatus_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DatumAbschluss).HasColumnType("datetime");

                entity.Property(e => e.DatumAnfrage).HasColumnType("datetime");

                entity.Property(e => e.DatumAnlage).HasColumnType("datetime");

                entity.Property(e => e.DatumRueckfrage).HasColumnType("datetime");

                entity.Property(e => e.DatumVersand).HasColumnType("datetime");

                entity.Property(e => e.DatumWiedervorlageBearbeiter).HasColumnType("datetime");

                entity.Property(e => e.DatumWiedervorlageEskalation).HasColumnType("datetime");

                entity.Property(e => e.Drgabschluss)
                    .HasColumnName("DRGAbschluss")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Drganlage)
                    .HasColumnName("DRGAnlage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailGesendet).HasColumnType("datetime");

                entity.Property(e => e.EmailGesendetVon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErledigungsstatusId).HasColumnName("Erledigungsstatus_ID");

                entity.Property(e => e.Fallnummer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FallnummerKenzeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KommentarRueckfrage).IsUnicode(false);

                entity.Property(e => e.Kostentraeger)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailadresseAuftraggeberVorgang)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MdkId)
                    .HasColumnName("Mdk_Id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notiz).IsUnicode(false);

                entity.Property(e => e.RechnungsDatumAbschluss).HasColumnType("datetime");

                entity.Property(e => e.RechnungsDatumAnlage).HasColumnType("datetime");

                entity.Property(e => e.RechnungsbetragAbschluss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RechnungsbetragAnlage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StandortId)
                    .HasColumnName("Standort_Id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Streitwert).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VorgangstypId).HasColumnName("Vorgangstyp_ID");

                entity.Property(e => e.ZuGunsten)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bearbeitungsstatus)
                    .WithMany(p => p.VwVorgang)
                    .HasForeignKey(d => d.BearbeitungsstatusId)
                    .HasConstraintName("FK_Vw_Vorgang_Vw_Bearbeitungsstatus");

                entity.HasOne(d => d.Erledigungsstatus)
                    .WithMany(p => p.VwVorgang)
                    .HasForeignKey(d => d.ErledigungsstatusId)
                    .HasConstraintName("FK_Vw_Vorgang_Vw_Erledigungsstatus");

                entity.HasOne(d => d.Standort)
                    .WithMany(p => p.VwVorgang)
                    .HasForeignKey(d => d.StandortId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_Vorgang_Vw_Standort");

                entity.HasOne(d => d.Vorgangstyp)
                    .WithMany(p => p.VwVorgang)
                    .HasForeignKey(d => d.VorgangstypId)
                    .HasConstraintName("FK_Vw_Vorgang_Vw_Vorgangstyp");
            });

            modelBuilder.Entity<VwVorgangControlItem>(entity =>
            {
                entity.ToTable("Vw_Vorgang_Control_Item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ControlId).HasColumnName("Control_id");

                entity.Property(e => e.ControlItemId).HasColumnName("ControlItem_id");

                entity.Property(e => e.VorgangId).HasColumnName("Vorgang_id");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.VwVorgangControlItem)
                    .HasForeignKey(d => d.ControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_Vorgang_Control_Item_Vw_Control");

                entity.HasOne(d => d.ControlItem)
                    .WithMany(p => p.VwVorgangControlItem)
                    .HasForeignKey(d => d.ControlItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_Vorgang_Control_Item_Vw_Control_Item");

                entity.HasOne(d => d.Vorgang)
                    .WithMany(p => p.VwVorgangControlItem)
                    .HasForeignKey(d => d.VorgangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_Vorgang_Control_Item_Vw_Vorgang");
            });

            modelBuilder.Entity<VwVorgangHistorie>(entity =>
            {
                entity.ToTable("Vw_VorgangHistorie");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MessageFarbe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Vorgang)
                    .WithMany(p => p.VwVorgangHistorie)
                    .HasForeignKey(d => d.VorgangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_VorgangHistorie_Vw_Vorgang");
            });

            modelBuilder.Entity<VwVorgangsbereich>(entity =>
            {
                entity.HasKey(e => e.VorgangsbereichId);

                entity.ToTable("Vw_Vorgangsbereich");

                entity.Property(e => e.VorgangsbereichId).HasColumnName("Vorgangsbereich_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwVorgangsdetail>(entity =>
            {
                entity.HasKey(e => e.VorgangsdetailId);

                entity.ToTable("Vw_Vorgangsdetail");

                entity.Property(e => e.VorgangsdetailId).HasColumnName("Vorgangsdetail_ID");

                entity.Property(e => e.BearbeitungsstatusId).HasColumnName("Bearbeitungsstatus_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Ergebnis)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Frist).HasColumnType("datetime");

                entity.Property(e => e.Notiz).IsUnicode(false);

                entity.Property(e => e.VorgangId).HasColumnName("Vorgang_ID");

                entity.Property(e => e.VorgangstypdetailId).HasColumnName("Vorgangstypdetail_ID");

                entity.Property(e => e.XmlMapping)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Bearbeitungsstatus)
                    .WithMany(p => p.VwVorgangsdetail)
                    .HasForeignKey(d => d.BearbeitungsstatusId)
                    .HasConstraintName("FK_Vw_Vorgangsdetail_Vw_Bearbeitungsstatus");

                entity.HasOne(d => d.Vorgang)
                    .WithMany(p => p.VwVorgangsdetail)
                    .HasForeignKey(d => d.VorgangId)
                    .HasConstraintName("FK_Vw_Vorgangsdetail_Vw_Vorgang");
            });

            modelBuilder.Entity<VwVorgangstyp>(entity =>
            {
                entity.HasKey(e => e.VorgangstypId);

                entity.ToTable("Vw_Vorgangstyp");

                entity.Property(e => e.VorgangstypId).HasColumnName("Vorgangstyp_ID");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalVorgangstypdetailId).HasColumnName("OriginalVorgangstypdetail_ID");

                entity.Property(e => e.VorgangsId).HasColumnName("Vorgangs_ID");

                entity.Property(e => e.VorgangsbereichId).HasColumnName("Vorgangsbereich_ID");

                entity.HasOne(d => d.Vorgangsbereich)
                    .WithMany(p => p.VwVorgangstyp)
                    .HasForeignKey(d => d.VorgangsbereichId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vw_Vorgangstyp_Vw_Vorgangsbereich");
            });

            modelBuilder.Entity<VwVorgangstypdetail>(entity =>
            {
                entity.HasKey(e => e.VorgangstypdetailId);

                entity.ToTable("Vw_Vorgangstypdetail");

                entity.Property(e => e.VorgangstypdetailId).HasColumnName("Vorgangstypdetail_ID");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VorgangstypId).HasColumnName("Vorgangstyp_ID");

                entity.Property(e => e.XmlMapping)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Vorgangstyp)
                    .WithMany(p => p.VwVorgangstypdetail)
                    .HasForeignKey(d => d.VorgangstypId)
                    .HasConstraintName("FK_Vw_Vorgangstypdetail_Vw_Vorgangstyp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
