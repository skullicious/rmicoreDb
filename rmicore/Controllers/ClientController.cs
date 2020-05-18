using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rmicore.ViewModels;

namespace rmicore.Controllers
{
    public class ClientController : Controller
    {

        //Inject service interface here


        //GET: Client
        [Route("Client/{policyType}")]
        public ActionResult Client(string policyType)
        {
            var clientViewModel = new ClientViewModel();

            clientViewModel.PolicyType = policyType;

            return View(clientViewModel);

        }


        [HttpPost]
        [Route("Client/{policyType}")]
        public ActionResult Client(ClientViewModel viewModel)
        {
            return null;
        }

    }
}