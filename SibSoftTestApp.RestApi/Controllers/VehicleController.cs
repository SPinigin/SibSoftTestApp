using Microsoft.AspNetCore.Mvc;
using SibSoftTestApp.RestApi.Data;
using SibSoftTestApp.RestApi.Models;

namespace SibSoftTestApp.RestApi.Controllers
{
    [Route("api/Vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly SibSoftDbContext _context;
        private readonly ILogger<VehicleController> _vehicleLogger;
        public VehicleController(SibSoftDbContext context, ILogger<VehicleController> vehicleLogger)
        {
            _context = context;
            _vehicleLogger = vehicleLogger;
            _vehicleLogger.LogDebug("VehicleLog");
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var vehicles = _context.Vehicles.ToList();
                if (vehicles.Count == 0)
                {
                    return NotFound("Транспортные средства недоступны");
                }
                return Ok(vehicles);
            }
            catch (Exception ex)
            {
                _vehicleLogger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Vehicle model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                _vehicleLogger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}