using Microsoft.AspNetCore.Mvc;
using ContossoPizza.Models;
using ContossoPizza.Services;

namespace ContossoPizza.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _service = new();

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pizza = _service.Get(id);
            return pizza == null ? NotFound() : Ok(pizza);
        }
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            _service.Add(pizza);
            return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
