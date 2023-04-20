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
            // C�digo que puede generar una excepci�n
            // ...
            throw new Exception("Este es un ejemplo de una excepci�n generada en el c�digo");
        }
        catch (Exception ex)
        {
            // Registrar la excepci�n como un log de error
            _logger.LogError(ex, "Ocurri� un error en el m�todo Get(). Detalles: {MensajeError}", ex.Message);
            // Otros niveles de severidad de logs tambi�n est�n disponibles, como LogWarning, LogInformation, etc.

            // Devolver con codigo de error
            return StatusCode(StatusCodes.Status500InternalServerError, "Ocurri� un error en el m�todo Get(). Detalles: " + ex.Message);
        }

        
    }
}
