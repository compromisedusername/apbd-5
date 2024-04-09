using Microsoft.AspNetCore.Mvc;
using SimpleApi.Database;
using SimpleApi.Services;

namespace SimpleApi.Controllers;

[ApiController]
[Route("[controller]")]

public class AnimalsController : ControllerBase
{
    private readonly IAnimalsService _animalsService;

    public AnimalsController(IAnimalsService animalsService)
    {
        _animalsService = animalsService;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;   
        return Ok(animals);
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animals = new MockDb().Animals;
        
        return Ok();
    }
}

