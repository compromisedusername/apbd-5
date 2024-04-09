using Microsoft.AspNetCore.Mvc;
using SimpleApi.Database;

namespace SimpleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;   
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animals = new MockDb().Animals;
        
        return Ok();
    }
}