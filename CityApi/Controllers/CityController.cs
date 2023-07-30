using CityApi.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace CityApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] int id)
        {
            var result = _cityService.GetCityById(id);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CityDto city)
        {
            _cityService.AddCity(city);
            return this.Ok();
        }

        [HttpGet("random")]
        public IActionResult GetRandom()
        {
            var randomCity = _cityService.GetRandomCity();
            if (randomCity == null)
                return NotFound();

            return Ok(randomCity);
        }

        [HttpGet("region")]
        public IActionResult GetCitiesByRegion(string region)
        {
            if (string.IsNullOrEmpty(region))
                return BadRequest("Region parameter is required.");

            var citiesInRegion = _cityService.GetCitiesByRegion(region);
            if (citiesInRegion == null || !citiesInRegion.Any())
                return NotFound();

            return Ok(citiesInRegion);
        }
    }
}