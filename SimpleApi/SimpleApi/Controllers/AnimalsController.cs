using Microsoft.AspNetCore.Mvc;
using SimpleApi.Database;
using SimpleApi.Services;
using Tutorial4.Models;

namespace SimpleApi.Controllers;

[ApiController]
[Route("api/animals")]

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
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalsService.GetAnimals().FirstOrDefault(an => an.Id == id);   
        return Ok(animal);
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _animalsService.GetAnimal(id) ;
        return StatusCode(StatusCodes.Status202Accepted);
    }

    [HttpPut("{id:int}")]
    public IActionResult EditAnimal(int id, Animal animal)
    {
        _animalsService.EditAnimal(id,animal);
        return StatusCode(StatusCodes.Status202Accepted);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
}

