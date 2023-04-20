using Microsoft.AspNetCore.Mvc;
using NewShoreTravels.App.API.ActionModels;
using NewShoreTravels.App.Business.Interfaces;
using NewShoreTravels.App.Business.Services;
using NewShoreTravels.App.DataAccess.Domain;

namespace NewShoreTravels.App.API.Controllers;

[ApiController]
[Route("[controller]")]
public class JourneyController : ControllerBase
{
    public readonly ILogger<JourneyController> _logger;
    public IJourneyService _journeyService;

    public JourneyController(ILogger<JourneyController> logger, IJourneyService journeyService)
    {
        _logger = logger;
        _journeyService = journeyService;
    }

    /// <summary>
    /// Get a Journey
    /// </summary>
    /// <param name="Origin">Origin of journey</param>
    /// <param name="Destination">Destination of journey</param>
    /// <returns>If get is succesfully, return a "Code status 200" with Journey object</returns>
    /// <response code = "400">
    /// When the search could not complete succesfully
    /// </response>
    [HttpGet]
    public IActionResult GetJourney([FromQuery]QueryJourney queryJourney)
    {
        Journey journeyDTO;
        try
        {
            // Validate fields
            if (String.IsNullOrEmpty(queryJourney.Origin) || String.IsNullOrEmpty(queryJourney.Destination))
            {
                return BadRequest("Origin and Destination are required");
            }
            // Call service
            journeyDTO = _journeyService.GetJourney(queryJourney.Origin,queryJourney.Destination);
        }
        catch (Exception ex)
        {
            // Log of exception
            _logger.LogError(ex, "Ocurrió un error en el método GetJourney(). Detalles: " + ex.Message);
            // Return error 
            return BadRequest(ex.Message);
        }

        return Ok(journeyDTO);

    }
}
