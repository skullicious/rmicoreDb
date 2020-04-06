using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using rmicore.Repository;
using rmicore.Entities;
using AutoMapper;
using rmicore;

namespace rminsurance.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController] 
    [EnableCors("ReactPolicy")]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;

       



        private readonly IBasicDataRepository<Title> _basicTitleDataRepository;

        private readonly IBasicDataRepository<Occupation> _basicOccupationDataRepository;

        private readonly IBasicDataRepository<OccupationStatus> _basicOccupationStatusDataRepository;

        private readonly IBasicDataRepository<EmploymentType> _basicEmploymentTypeDataRepository;



        public TestController(IMapper mapper,IBasicDataRepository<Title> basicTitleDataRepository, 
            IBasicDataRepository<Occupation> basicOccupationDataRepository, 
            IBasicDataRepository<OccupationStatus> basicOccupationStatusDataRepository, 
            IBasicDataRepository<EmploymentType> basicEmploymentTypeDataRepository)
        {
            _basicTitleDataRepository = basicTitleDataRepository;
            _basicOccupationDataRepository = basicOccupationDataRepository;
            _basicOccupationStatusDataRepository = basicOccupationStatusDataRepository;
            _basicEmploymentTypeDataRepository = basicEmploymentTypeDataRepository;
            _mapper = mapper;
        }
             
        //// GET: api/Title
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    IEnumerable<Title> titles = _dataRepository.GetAll();
        //    return Ok(titles);
        //}


        [HttpGet("titles")] // GET /api/test/titles/
        public IActionResult GetTitles()
        {
            IEnumerable<Title> titles = _basicTitleDataRepository.GetAll();
                     
            //IEnumerable<SimpleReactObjectViewModel> test = (_mapper.Map<List<SimpleReactObjectViewModel>>(titles));

            return Ok(_mapper.Map<List<SimpleReactObjectViewModel>>(titles));
        }

        [HttpGet("occupations")] // GET /api/test/occcupations/
        public IActionResult GetOccupations()
        {
            IEnumerable<Occupation> occupations = _basicOccupationDataRepository.GetAll();
                  

            return Ok(_mapper.Map<List<SimpleReactObjectViewModel>>(occupations));
        }

        [HttpGet("occupationstatus")] // GET /api/test/occcupationStatus/
        public IActionResult GetOccupationStatus()
        {
            IEnumerable<OccupationStatus> occupationStatus = _basicOccupationStatusDataRepository.GetAll();

            return Ok(_mapper.Map<List<SimpleReactObjectViewModel>>(occupationStatus));
        }


        [HttpGet("employmenttypes")] // GET /api/test/occcupationStatus/
        public IActionResult GetEmploymentTypes()
        {
            IEnumerable<EmploymentType> employmentTypes = _basicEmploymentTypeDataRepository.GetAll();

            return Ok(_mapper.Map<List<SimpleReactObjectViewModel>>(employmentTypes));
        }


        public override NoContentResult NoContent()
        {
            return base.NoContent();
        }
    }
}
