using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaziMobilAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicCalendersController : ControllerBase
    {
        IAcademicCalenderService _academicCalenderService;
        public AcademicCalendersController(IAcademicCalenderService academicCalenderService)
        {
            _academicCalenderService = academicCalenderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _academicCalenderService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _academicCalenderService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
