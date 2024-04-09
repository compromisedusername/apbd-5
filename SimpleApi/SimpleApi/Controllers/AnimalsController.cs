using Microsoft.AspNetCore.Mvc;
using SimpleApi.Database;
using SimpleApi.Services;
using Tutorial4.Models;

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
        var animals = _animalsService.GetAnimals();   
        return Ok(animals);
    }
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalsService.GetAnimal(id);   
        return Ok(animal);
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _animalsService.GetAnimal(id) ;
        return Ok(animal);
    }

    [HttpPost("{id}")]
    public IActionResult EditAnimal(int id, Animal animal)
    {
        _animalsService.EditAnimal(id,animal);
        return Ok(animal);
    }
}

