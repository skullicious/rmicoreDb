﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public virtual ICollection<Individual> Individuals {get; set;}   

        public virtual ICollection<Rider> Riders { get; set; }
    }
}
