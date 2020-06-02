using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using rmicore.Repository;
using rmicore.Entities;
using AutoMapper;
using rmicore;
using rmicore.Interface;

namespace rminsurance.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    public class DataController : ControllerBase
    {

        private readonly IDataService _dataService;  

        public DataController(IDataService dataService)           
        {           
            _dataService = dataService;          
        }             
  

        [HttpGet("titles")] // GET /api/test/titles/
        public IActionResult GetTitles()
        {       
            List<SimpleReactObjectViewModel> result = _dataService.GetAllTitles();

            return Ok(result);
        }

        [HttpGet("occupations")] // GET /api/test/occcupations/
        public IActionResult GetOccupations()
        {
            List<SimpleReactObjectViewModel> result = _dataService.GetAllOccupations();

            return Ok(result);
        }

        [HttpGet("occupationstatus")] // GET /api/test/occcupationStatus/
        public IActionResult GetOccupationStatus()
        {
            List<SimpleReactObjectViewModel> result = _dataService.GetAllOccupationStatuses();

            return Ok(result);
        }

        [HttpGet("employmenttypes")] // GET /api/test/employmenttypes/
        public IActionResult GetEmploymentTypes()
        {
            List<SimpleReactObjectViewModel> result = _dataService.GetAllEmploymentTypes();

            return Ok(result);
        }


        [HttpGet("licensetypes")] // GET /api/test/licensetypes/
        public IActionResult GetLicenseTypes()
        {
            List<SimpleReactObjectViewModel> result = _dataService.GetAllLicenseTypes();

            return Ok(result);
        }


        [HttpGet("vehicleuses")] // GET /api/test/vehicleuses/
        public IActionResult GetVehicleUses()
        {
            List<SimpleReactObjectViewModel> result = _dataService.GetAllVehicleUses();

            return Ok(result);
        }

        [HttpGet("cycleuses")] // GET /api/test/cycleuses/
        public IActionResult GetCycleUses()
        {
            List<SimpleReactObjectViewModel> result = _dataService.GetAllCycleUses();

            return Ok(result);
        }

        public override NoContentResult NoContent()
        {
            return base.NoContent();
        }
    }
}
