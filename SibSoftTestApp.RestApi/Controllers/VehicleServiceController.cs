using Microsoft.AspNetCore.Mvc;
using SibSoftTestApp.RestApi.Data;
using SibSoftTestApp.RestApi.Models;

namespace SibSoftTestApp.RestApi.Controllers
{
    [Route("api/VehicleService")]
    [ApiController]
    public class VehicleServiceController : ControllerBase
    {
        private readonly SibSoftDbContext _context;
        private readonly ILogger<VehicleServiceController> _vehicleServiceLogger;
        public VehicleServiceController(SibSoftDbContext context, ILogger<VehicleServiceController> vehicleServiceLogger)
        {
            _context = context;
            _vehicleServiceLogger = vehicleServiceLogger;
            _vehicleServiceLogger.LogDebug("VehicleServiceLog");
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var vehicleServices = _context.VehicleServices.ToList();
                if (vehicleServices.Count == 0)
                {
                    return NotFound("Заказы недоступны");
                }
                return Ok(vehicleServices);
            }
            catch (Exception ex)
            {
                _vehicleServiceLogger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(VehicleService model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                _vehicleServiceLogger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}