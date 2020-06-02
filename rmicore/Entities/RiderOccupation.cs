using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class RiderOccupation
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public string occupation { get; set; }

        public string partTime { get; set; }

        public string employmentType { get; set; }

        public string occupationStatus { get; set; }

    }
}
