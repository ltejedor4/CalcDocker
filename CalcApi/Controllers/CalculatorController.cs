using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("{operacion}/{*operadores}")]
        public ActionResult RealizarCalculo(string operacion, string operadores)
        {
            var operandos = operadores.Split("/");
            double resultado = 0;
            if (operandos.Count() < 2)
                return BadRequest();

            switch (operacion)
            {
                case "sum":
                    foreach (var opera in operandos)
                        resultado += Convert.ToDouble(opera);
                    break;
                case "res":
                    resultado = Convert.ToDouble(operandos[0]) - Convert.ToDouble(operandos[1]);
                    break;
                case "mul":
                    resultado = 1;
                    foreach (var opera in operandos)
                        resultado += Convert.ToDouble(opera);
                    break;
                case "div":
                    if (Convert.ToDouble(operandos[1]) == 0)
                        return BadRequest();
                    resultado = Convert.ToDouble(operandos[0]) / Convert.ToDouble(operandos[1]);
                    break;
                default:                    
                    return BadRequest();                   
            }

            return Ok(resultado);
        }
    }
}