using LocationApp.Application.Places;
using LocationApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocationApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly IPlacesService _placesService;

        public PlacesController(IPlacesService placesService)
        {
            _placesService = placesService;
        }

        [HttpGet]
        [Route("/")]
        public async Task<IActionResult> GetPlacesAsync()
        {
            List<PlaceDto> places = await _placesService.GetPlacesAsync();
            return Ok(places);
        }

        [HttpPost]
        [Route("/")]
        public async Task<IActionResult> AddPlaceAsync(AddPlaceDto dto)
        {
            var result = await _placesService.AddPlaceAsync(dto);
            return Ok(result);
        }
    }
}
