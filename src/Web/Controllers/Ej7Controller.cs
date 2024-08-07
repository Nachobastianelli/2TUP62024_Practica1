using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]int startNumber, [FromQuery]int endNumber)
    {
        int i;
        List<int> numbers = new List<int>();
        if ((endNumber - startNumber) > 1000)
        {
            return BadRequest("La diferencia tiene que ser menor a mil...");
        }
        for ( i = startNumber; i < endNumber; i++)
        {
            numbers.Add(i);
        }
        return Ok(numbers);
    }
}

/*
 


 */