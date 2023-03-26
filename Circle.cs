
namespace ConsoleApp1
{
    public class Circle : ShapeBase, Lenghtable
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public double Lenght()
        {
            return 2 * Math.PI * this.radius;
        }
        public override string ToString()
        {
            return $"{base.ToString()} окружность с радиусом {this.radius}";
        }
    }
}
