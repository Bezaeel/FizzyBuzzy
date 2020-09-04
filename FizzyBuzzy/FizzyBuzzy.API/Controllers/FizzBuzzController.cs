using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzyBuzzy.Service.Features.FizzBuzz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzyBuzzy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzz _fb;
        public FizzBuzzController(IFizzBuzz fizzBuzz)
        {
            _fb = fizzBuzz;
        }

        [HttpGet("ping")]
        public IActionResult ping()
        {
            return Ok("Ask Talabi..");
        }

        [HttpGet("generate/{num}")]
        public async Task<IActionResult> FizzBuzz(int num)
        {
            if(num == null)
            {
                return BadRequest("number cannot be null");
            }
            if(num < 1 || num > 100)
            {
                return BadRequest("number cannot be less than 1 or greater than 100");
            }
            var result = await _fb.GenerateFizzBuzz(num);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return StatusCode(500, result);
        }
    }
}