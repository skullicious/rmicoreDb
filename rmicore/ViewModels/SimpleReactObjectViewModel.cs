using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Entities
{

    [NotMapped]

    public class SimpleReactObjectViewModel
    {
      
        public string _id { get; set; }
       
        public string name{ get; set; }
       


    }
}
