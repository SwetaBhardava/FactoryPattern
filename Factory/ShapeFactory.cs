using FactoryPattern.Models;

namespace FactoryPattern.Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == "Circle")
            {
                return new Circle();
            }
            else if (shapeType == "Rectangle")
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
