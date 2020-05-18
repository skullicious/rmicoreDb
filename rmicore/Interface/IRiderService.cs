using rmicore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Interface
{
    public interface IRiderService
    {
        Rider GetRiderById(int riderId);
    }
}
