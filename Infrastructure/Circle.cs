namespace ConsoleApp1.Infrastructure
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
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Lenght()
        {
            return 2 * Math.PI * radius;
        }
        public override string ToString()
        {
            return $"{base.ToString()} окружность с радиусом {radius}";
        }
    }
}
