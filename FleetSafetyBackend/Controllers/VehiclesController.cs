using FleetSafetyBackend.Data; // Include the namespace for the DbContext
using Microsoft.AspNetCore.Mvc; // For API controllers
using Microsoft.EntityFrameworkCore; // For async database queries
using System.Threading.Tasks;

namespace FleetSafetyBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly FleetSafetyDbContext _context;

        // Inject DbContext into the controller
        public VehiclesController(FleetSafetyDbContext context)
        {
            _context = context;
        }

        // GET /api/vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            try
            {
                // Fetch all vehicles from the database
                var vehicles = await _context.Vehicles.ToListAsync();
                return Ok(vehicles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Database connection failed: {ex.Message}");
            }
        }
    }
}
