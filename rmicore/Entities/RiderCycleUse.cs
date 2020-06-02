using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class RiderCycleUse
    { 

        public int Id { get; set; }

        public int UserId { get; set; }

        public string cycleUse { get; set; }

        public string isCommuting { get; set; }

        public string motoringQualification { get; set; }

        public string licenseType { get; set; }

    }
}
