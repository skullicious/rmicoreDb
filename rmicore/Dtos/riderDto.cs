using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Dtos
{
    public class riderDto
    {
        public riderDto()
        {

            individual = new Individual();
        }

        public int Id { get; set; }
        public Individual individual { get; set;}

    }
}
