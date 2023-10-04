using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // ATRIBUTE : 

    //IOC   Inversion Of Control
    public class RentalsController : ControllerBase
    {
        private IRentalService _rentalService;


        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            
            return BadRequest(result);
            
        }

        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _rentalService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("add")]
        public IActionResult Post(Rental rental)
        {
            var result = _rentalService.Add(rental);
            return Ok(result);
            return BadRequest(result);
        }




        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            var  result = _rentalService.Delete(rental);
            if (true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpGet("details")]
        public IActionResult GetRentalDetails()
        {
            var result = _rentalService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
