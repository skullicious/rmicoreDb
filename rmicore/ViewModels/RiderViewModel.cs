using Microsoft.AspNetCore.Identity;
using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.ViewModels
{
    public class RiderViewModel
    {
        public RiderViewModel()
        {
            //rider = new Rider();
           individual = new Individual();


           contact = new Contact();

           contact.address = new Address();

           contact.Email = new Email();

           contact.phoneNumber = new PhoneNumber();

           occupation = new RiderOccupation();

           cycleUse = new RiderCycleUse();
            
        }

        public int Id { get; set; }
       
        public Individual individual { get; set; }

        public Contact contact { get; set; }

        public Email email { get; set; }

        public PhoneNumber phoneNumber { get; set; }

        public RiderOccupation occupation { get; set; }      

        public RiderCycleUse cycleUse { get; set; }


    }
}
