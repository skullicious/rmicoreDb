﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class Email
    {


       
        public int EmailId { get; set; }         
        
        public int UserId { get; set; }       

        public string EmailAddress { get; set; }

     
    }
}
