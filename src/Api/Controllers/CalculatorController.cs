using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("/calculator/add/{number1}/{number2}")]
        public int Add(int number1, int number2)
        {
            return (number1 + number2);
        }
    }
}
