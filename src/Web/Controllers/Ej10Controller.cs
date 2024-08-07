using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej10Controller : ControllerBase
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
        var divisibles3 = list.Where(x => x % 3  == 0).ToList();

        string pares = string.Join(", ", filteredNumbers);
        string divisiblesPor3 = string.Join(", ", divisibles3);


        string message = $"Pares: {pares}\nDivisibles por 3: {divisiblesPor3}";
        return Ok(message);
    
    }

   
}

/*
 
10) Recorrer los números del 1 al 100. Crear 2 listas, una con los números pares y otra con
los divisibles entre 3. Mostrar las 2 listas.

 */