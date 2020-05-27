using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rmicore.Dtos;
using rmicore.Entities;
using rmicore.ViewModels;
using rmicore.Interface;

namespace rmicore.Controllers
{
    
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {       
        private readonly IRiderService _riderService;
        private readonly IDataService _dataService;

        public PersonController(IRiderService riderService, IDataService dataService)
        {
            _riderService = riderService;
            _dataService = dataService;
        }
             

        [HttpPost("rider/save")]
        public IActionResult SaveRider([FromBody]RiderViewModel riderVm)      
        {

            //MAP RIDER TO VM TO DTO
           var riderDto = _dataService.MapViewModelToDto(riderVm);

            _riderService.FullPagePost(riderDto);

            return Ok();
        }
               

        [HttpPut("rider/{id}")]
        public IActionResult RiderDetails(int id, [FromBody]UserDto userDto)
        {
            User user = _riderService.GetRiderById(userDto.Id);
            if (user == null)
                //return RedirectToAction("Proposer", "Proposers", new { policyType = "Rider" });
                return Ok();

            RiderViewModel viewModel = new RiderViewModel();
            viewModel = _riderService.PopulateRiderViewModel(user, viewModel);

            return Ok(viewModel);
        }
    }
}