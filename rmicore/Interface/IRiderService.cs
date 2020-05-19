using rmicore.Entities;
using rmicore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Interface
{
    public interface IRiderService
    {
        Rider GetRiderById(int riderId);

        RiderViewModel PopulateRiderViewModel(Rider rider, RiderViewModel viewModel);
    }
}
