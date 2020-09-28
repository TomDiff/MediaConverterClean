using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VAusleihstatusKlartext
    {
        public string EntleiherNachname { get; set; }
        public string EntleiherVorname { get; set; }
        public string AusleihLagerortBezeichnung { get; set; }
        public DateTime? Ausleihdatum { get; set; }
        public DateTime? Faelligkeitsdatum { get; set; }
        public int? RueckgabeMahnstufe { get; set; }
        public byte? AnzahlVerlaengerungen { get; set; }
        public string Ausleihgrund { get; set; }
        public int AkteId { get; set; }
        public int? HausId { get; set; }
    }
}
