using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public int RiderId { get; set; }

        public int TypeId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string AddressLine4 { get; set; }

        public string AddressLine5 { get; set; }

        public string PostCode { get; set; }

        public string ConfirmedAddress { get; set; }




    }

}
