using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej8Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        int count = 0;
        List<int> list = new List<int>(); 

        while (count < 100)
        {
            count++;
            list.Add(count);
        }

        return Ok(list);
    
    }
}

/*
 
8) Recorrer los números del 1 al 100. Usar un bucle while.

 */