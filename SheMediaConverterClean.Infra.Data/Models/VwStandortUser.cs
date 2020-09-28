using System;
using System.Collections.Generic;

namespace SheMediaConverterClean.Infra.Data.Models
{
    public partial class VwStandortUser
    {
        public int StandortUserId { get; set; }
        public int StandordId { get; set; }
        public int UserId { get; set; }

        public virtual VwStandort Standord { get; set; }
    }
}
