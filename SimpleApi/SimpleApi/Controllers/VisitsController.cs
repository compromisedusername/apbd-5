using Microsoft.AspNetCore.Mvc;
using SimpleApi.Services;
using Tutorial4.Models;

namespace SimpleApi.Controllers;


[ApiController]
[Route("api/visits")]

public class VisitsController : ControllerBase
{
    private readonly IVisitsService _visitsService;

    public VisitsController(IVisitsService visitsService)
    {
        _visitsService = visitsService;
    }

    [HttpGet("{id:int}")]
    public IActionResult GetVisits(int id)
    {
        var visits = _visitsService.GetVisits(id);
        return Ok(visits);
    }

    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        _visitsService.CreateVisits(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
}