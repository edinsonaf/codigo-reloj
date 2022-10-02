using Microsoft.AspNetCore.Mvc;

namespace WebApiRestReloj
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet("{cboreloj}")]
        public IEnumerable<ReporteAsistencia> PostAsistencia(string cboreloj)
        {
            Masistencia nasis = new Masistencia();
            var resul = nasis.nreporte(cboreloj);
            return resul;
        }
    }
}