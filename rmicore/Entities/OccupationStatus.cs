using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class OccupationStatus
    {
        [Key]
        public int OccupationStatusId { get; set; }       
        public string Name { get; set; }
      
    }
}
