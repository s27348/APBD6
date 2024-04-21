using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalController : ControllerBase
{
    private readonly IAnimalsService _animalsService;
    
    public AnimalController(IAnimalsService animalsService)
    {
        _animalsService = animalsService;
    }
    
    [HttpGet]
    public IActionResult GetAnimals(string orderBy = "Name")
    {
        switch (orderBy.ToLower())
        {
            case "Name":
                orderBy = "Name";
                break;
            case "Description":
                orderBy = "Description";
                break;
            case "Category":
                orderBy = "Category";
                break;
            case "Area":
                orderBy = "Area";
                break;
            default:
                orderBy = "Name";
                break;
        }
        
        var animals = _animalsService.GetAnimals(orderBy);
        return Ok(animals);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animalsService.CreateAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        _animalsService.UpdateAnimal(id, animal);
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        _animalsService.DeleteAnimal(id);
        return NoContent();
    }
}