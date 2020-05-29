using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual Address Address { get; set; }

        public virtual Email email { get; set; }

        //public virtual PhoneNumber PhoneNumber { get; set; }


        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; } = new HashSet<PhoneNumber>(); // to initialise so not null in service

        public virtual ICollection<Rider> Riders { get; set; }
    }
}
