using Microsoft.AspNetCore.Mvc;
using MediatR;
using LeGordon.Adm.Application;

namespace Legordon.Adm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public ProductsController(IMediator mediator)
        {
            _mediatr = mediator;
        }


        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommand createProduct)
        {
            return Accepted( await _mediatr.Send(createProduct) );
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
    }
}
