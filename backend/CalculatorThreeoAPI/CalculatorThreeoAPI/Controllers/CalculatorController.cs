using CalculatorThreeoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorThreeoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        Calc mCalc = new Calc();

        [HttpGet]
        [Route("add/{firstParam}/{secondParam}")]
        public float Add(float firstParam, float secondParam)
        {
            return mCalc.Add(firstParam, secondParam);
        }


    }
}
