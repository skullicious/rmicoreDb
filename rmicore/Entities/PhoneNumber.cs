using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class PhoneNumber
    {


        public int Id { get; set; }           
      
        public int UserId { get; set; }

        public string Number { get; set; }


    }
}
