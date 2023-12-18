using Microsoft.AspNetCore.Mvc;
using SibSoftTestApp.RestApi.Data;
using SibSoftTestApp.RestApi.Models;

namespace SibSoftTestApp.RestApi.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly SibSoftDbContext _context;
        private readonly ILogger<CustomerController> _customerLogger;
        public CustomerController(SibSoftDbContext context, ILogger<CustomerController> customerLogger)
        {
            _context = context;
            _customerLogger = customerLogger;
            _customerLogger.LogDebug("CustomerLog");
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var customers = _context.Customers.ToList();
                if (customers.Count == 0)
                {
                    return NotFound("Заказчики недоступны");
                }
                return Ok(customers);
            }
            catch (Exception ex)
            {
                _customerLogger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Customer model)
        {
            try
            {
                _context.Add(model);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                _customerLogger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}