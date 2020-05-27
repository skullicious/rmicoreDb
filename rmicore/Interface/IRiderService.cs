using rmicore.Dtos;
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
        User GetRiderById(int riderId);

        

        RiderViewModel PopulateRiderViewModel(User rider, RiderViewModel viewModel);

        bool FullPagePost(riderDto viewModel);

       
    }
}
