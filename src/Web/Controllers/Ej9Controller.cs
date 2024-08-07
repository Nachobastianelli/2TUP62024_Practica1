using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej9Controller : ControllerBase
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

        var filteredNumbers = list.Where(x => x % 2 == 0).ToList();

        return Ok(filteredNumbers);
    
    }

   
}

/*
 
9) Recorrer los números del 1 al 100. Mostrar los números pares. Usar el tipo de bucle que quieras.

 */