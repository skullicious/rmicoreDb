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
            //rider.Individual = new Individual();
            
        }

        public int Id { get; set; }
        public string individual_title { get; set; }

        public string individual_firstName { get; set; }

        public string individual_lastName { get; set; }

        public string status_postcode { get; set; }

        public string status_email { get; set; }

        public string status_contactNumber { get; set; }

        public string occupation_occupation { get; set; }

        public string occupation_occupationStatus { get; set; }

        public string occupation_partTime { get; set; }

        public string occupation_employmentType { get; set; }

        public string vehicleUse_licenseType { get; set; }

        public string vehicleUse_vehicleUse { get; set; }

        public string vehicleUse_licenseRestriction { get; set; }

        public string vehicleUse_motoringQualification { get; set; }

        //public Rider rider { get; set; }

   


    }
}
