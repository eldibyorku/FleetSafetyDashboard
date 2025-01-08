using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetVehicles()
    {
        var vehicles = new[]
        {
            new { Id = 1, Name = "Truck A", Status = "Online" },
            new { Id = 2, Name = "Truck B", Status = "Offline" }
        };
        return Ok(vehicles);
    }
}
