using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.ViewModels
{
    public class ClientViewModel
    {
        public int ClientId { get; set; }

        public Rider Rider { get; set; }
        
        public string PolicyType { get; set; }


        public ClientViewModel()
        {
            Rider = new Rider();
            
        }

    }


}
