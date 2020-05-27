using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class Contact
    {

        public int Id { get; set; }

        public int UserId { get; set; }       

        public Address address { get; set; }     
        
        public Email Email { get; set; }
           

    }
}

