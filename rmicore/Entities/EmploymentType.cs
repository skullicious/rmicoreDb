﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class EmploymentType
    {
        [Key]
        public int EmploymentTypeId { get; set; }       
        public string Name { get; set; }
      
    }
}
