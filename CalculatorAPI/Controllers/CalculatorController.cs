using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Add(decimal a, decimal b)
        {
            decimal result = a + b;
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Subtract(decimal a, decimal b)
        {
            decimal result = a - b;
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Multiply(decimal a, decimal b)
        {
            decimal result = a * b;
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            decimal result = a / b;
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Modulo(decimal a, decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Modulo by zero is not allowed.");
            }
            decimal result = a % b;
            return Ok(result);
        }
    }
}
