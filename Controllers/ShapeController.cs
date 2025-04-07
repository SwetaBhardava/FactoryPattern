using FactoryPattern.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly ShapeFactory _shapeFactory;

        public ShapeController()
        {
            _shapeFactory = new ShapeFactory();
        }
        [HttpGet("{shapeType}")]
        public ActionResult<string> GetShape(string shapeType)
        {
            var shape = _shapeFactory.GetShape(shapeType);

            if(shape == null)
            {
                return NotFound("Shape not found");
            }
            return Ok(shape.Draw());
        }
    }
}
