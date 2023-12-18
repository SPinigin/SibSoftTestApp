using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SibSoftTestApp.RestApi.Data;
using SibSoftTestApp.RestApi.Models;

namespace SibSoftTestApp.RestApi.Controllers
{
    [Route("api/Performer")]
    [ApiController]
    public class PerformerController : ControllerBase
    {
        private readonly SibSoftDbContext _context;
        private readonly ILogger<PerformerController> _performerLogger;
        public PerformerController(SibSoftDbContext context, ILogger<PerformerController> performerLogger)
        {
            _context = context;
            _performerLogger = performerLogger;
            _performerLogger.LogDebug("PerformerLog");
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var performer = _context.Performers.ToList();
                if (performer.Count == 0)
                {
                    return NotFound("Исполнители недоступны");
                }
                return Ok(performer);
            }
            catch (Exception ex)
            {
                _performerLogger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Performer model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                _performerLogger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}