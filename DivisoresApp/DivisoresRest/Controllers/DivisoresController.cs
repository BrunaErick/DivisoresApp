using Microsoft.AspNetCore.Mvc;

namespace DivisoresRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisoresController : ControllerBase
    {
       [HttpGet("{numero}")]
        public ActionResult<DivisorResponse>  GetDivisores(int numero)
        {
            if (numero <= 0)
            {
                return BadRequest("O número deve ser maior que zero.");
            }

            var resultado = DivisorProgram.contasWebApi(numero.ToString());
            return Ok(resultado);
        }
    }

    public class DivisorResponse
    {
        public int Numero { get; set; }
        public List<int> Divisores { get; set; }
        public List<int> Primos { get; set; }
    }
}
