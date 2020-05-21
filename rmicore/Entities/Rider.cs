using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class Rider
    {

        public int Id { get; set; }
        public int UserId { get; set; }
            
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    
        public virtual ICollection<Address> Addresses { get; set; }

        
        
       
    }
}


