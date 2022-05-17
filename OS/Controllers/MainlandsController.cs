using Microsoft.AspNetCore.Mvc;
using OS.Data;
using OS.Models;

namespace OS.Controllers;
[ApiController]
public class MainlandsController:ControllerBase
{
    private readonly IMainlandStorage _context;

    public MainlandsController(IMainlandStorage context)
    {
        _context = context;
    }

    [HttpGet("api/mainlands")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Mainland>))]
    [ProducesResponseType(404)]
    public IActionResult GetAllMainlands()
    {
        return Ok(_context.GetAllMainlands());
    }
    
    [HttpGet("api/mainlands/{id}")]
    [ProducesResponseType(200, Type = typeof(Mainland))]
    [ProducesResponseType(404)]
    public IActionResult GetArealById(int id)
    {
        var mainland = _context.GetMainlandById(id);
        return mainland == default ? NotFound(mainland) : Ok(mainland);
    }
    
    [HttpGet("api/mainlands/remove/{id}")]
    [ProducesResponseType(200, Type = typeof(Mainland))]
    [ProducesResponseType(404)]
    public IActionResult RemoveMainlandById(int id)
    {
        var mainland = _context.RemoveMainlandById(id);
        return mainland == default ? NotFound(mainland) : Ok(mainland);
    }
}