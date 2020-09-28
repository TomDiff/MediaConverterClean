using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VXrayErfassen
    {
        public int Id { get; set; }
        public string PatientNachname { get; set; }
        public string PatientVorname { get; set; }
        public DateTime? PatientGeburtsdatum { get; set; }
    }
}
