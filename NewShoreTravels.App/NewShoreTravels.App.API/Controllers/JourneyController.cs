using Microsoft.AspNetCore.Mvc;
using NewShoreTravels.App.Business.Interfaces;
using NewShoreTravels.App.Business.Services;

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

    [HttpGet(Name = "Journey")]
    public IActionResult Get()
    {
        try
        {
            // Código que puede generar una excepción
            // ...
            throw new Exception("Este es un ejemplo de una excepción generada en el código");
        }
        catch (Exception ex)
        {
            // Registrar la excepción como un log de error
            _logger.LogError(ex, "Ocurrió un error en el método Get(). Detalles: {MensajeError}", ex.Message);
            // Otros niveles de severidad de logs también están disponibles, como LogWarning, LogInformation, etc.

            // Devolver con codigo de error
            return StatusCode(StatusCodes.Status500InternalServerError, "Ocurrió un error en el método Get(). Detalles: " + ex.Message);
        }

        
    }
}
