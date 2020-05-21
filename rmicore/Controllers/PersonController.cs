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


        //private static readonly string[] Summaries = new[]
        // {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};




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




        [HttpPut("test/{id}")] // GET /api/test/titles/
        public IActionResult GetTitles(int id, [FromBody]UserDto userDto)

          
        {
            RiderViewModel viewModel = new RiderViewModel();

            viewModel.Id = userDto.Id;

            viewModel.individual_firstName = "Damo";

            viewModel.individual_lastName = "Sweeno";

            viewModel.individual_title = "2";

            viewModel.status_postcode = "UB6 8SX";
            
            viewModel.status_email = "damien.sweeney81@googlemail.com";

            viewModel.status_contactNumber = "02085781356";

            viewModel.occupation_employmentType = "3";

            viewModel.occupation_occupation = "4";

            viewModel.occupation_occupationStatus = "2";

            viewModel.occupation_partTime = "false";

            viewModel.vehicleUse_vehicleUse = "1";

            viewModel.vehicleUse_licenseType = "4";

            viewModel.vehicleUse_licenseRestriction = "false";

            viewModel.vehicleUse_motoringQualification = "true";


          
            return Ok(viewModel);
        }
    }
}