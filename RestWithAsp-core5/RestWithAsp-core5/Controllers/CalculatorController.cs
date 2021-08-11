using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp_core5.Controllers
{
    [Route("api/calculator")]
    public class CalculatorController : ControllerBase
    {

        [HttpGet("sum/{firtsNumber}/{secondNumber}")]
        public IActionResult Get(string firtsNumber, string secondNumber)
        {
            if (IsNumeric(firtsNumber) && IsNumeric(secondNumber))
            {

            }
            return BadRequest();
        }

        private bool IsNumeric(string firtsNumber)
        {
            throw new NotImplementedException();
        }
    }
}
