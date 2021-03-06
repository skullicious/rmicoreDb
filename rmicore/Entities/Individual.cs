﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class Individual
    {

        public int Id { get; set; }

        public int UserId { get; set; }                 

        public string title { get; set; }              

        public string lastName { get; set; }

        public string firstName { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateOfBirth { get; set; }


    }
}

