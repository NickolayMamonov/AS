using Microsoft.AspNetCore.Mvc;
using OS.Data;
using OS.Models;

namespace OS.Controllers;
[ApiController]
public class CountriesController : ControllerBase
{
    private readonly ICountryStorage _context;

    public CountriesController(ICountryStorage context)
    {
        _context = context;
    }

    [HttpGet("api/countries")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Country>))]
    [ProducesResponseType(404)]
    public IActionResult GetAll()
    {
        return Ok(_context.GetAllCountries());
    }
    
    [HttpGet("api/countries/{id}")]
    [ProducesResponseType(200, Type = typeof(Country))]
    [ProducesResponseType(404)]
    public IActionResult GetById(int id)
    {
        var country = _context.GetCountryById(id);
        return country == default ? NotFound(country) : Ok(country);
    }
    
    [HttpGet("api/countries/byname/{name}")]
    [ProducesResponseType(200, Type = typeof(Country))]
    [ProducesResponseType(404)]
    public IActionResult GetByName(string name)
    {
        var country = _context.GetCountryByName(name);
        return country == default ? NotFound(country) : Ok(country);
    }
    
    [HttpGet("api/countries/remove/{id}")]
    [ProducesResponseType(200, Type = typeof(Country))]
    [ProducesResponseType(404)]
    public IActionResult RemoveById(int id)
    {
        var country = _context.RemoveCountryById(id);
        return country == default ? NotFound(country) : Ok(country);
    }
    
}