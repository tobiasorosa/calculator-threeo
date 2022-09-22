using CalculatorThreeoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorThreeoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        readonly Calc mCalc = new();

        [HttpGet]
        [Route("add/{firstParam}/{secondParam}")]
        public float GetAdd(float firstParam, float secondParam)
        {
            return mCalc.Add(firstParam, secondParam);
        }

        [HttpGet]
        [Route("sub/{firstParam}/{secondParam}")]
        public float GetSub(float firstParam, float secondParam)
        {
            return mCalc.Sub(firstParam, secondParam);
        }

        [HttpGet]
        [Route("mult/{firstParam}/{secondParam}")]
        public float GetMult(float firstParam, float secondParam)
        {
            return mCalc.Mult(firstParam, secondParam);
        }

        [HttpGet]
        [Route("div/{firstParam}/{secondParam}")]
        public float GetDiv(float firstParam, float secondParam)
        {
            return mCalc.Div(firstParam, secondParam);
        }
    }
}
