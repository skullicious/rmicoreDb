using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace rmicore.Entities
{
 
  
    public class Test
    {
      
        public Guid TestId { get; set; }

        [Required(ErrorMessage = "Date created is required")]

        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage = "Account type is required")]
        public string AccountType { get; set; }


    }
}
