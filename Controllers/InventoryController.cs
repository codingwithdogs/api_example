using Microsoft.AspNetCore.Mvc;
using interview.Models;
using interview.Data;

namespace interview.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{

    private readonly object _logger;
    private readonly object _repository;

    public InventoryController(
        object logger,
        object repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpGet(Name = "GetInventory")]
    public ActionResult<List<Inventory>> Get()
    {
        return Ok(_repository.GetInventory());
    }
}
