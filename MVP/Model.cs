using ConsoleApp1.Infrastructure;

namespace ConsoleApp1.MVP
{
    public class Model
    {
        private ShapeSet shapes;
        public Model(ShapeSet shape)
        {
            shapes = shape;
        }
        public ShapeSet ShapeSet { get { return shapes; } }
        public void removeEl(int index)
        {
            shapes.removeShape(index);
        }
    }
}
