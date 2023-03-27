

namespace ConsoleApp1.Infrastructure
{
    public class Rectangle : ShapeBase, Perimetrable
    {
        protected int sideA;
        protected int sideB;
        public Rectangle(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public override double Area()
        {
            return sideA * sideB;
        }

        public double Perimetrable()
        {
            return 2 * (sideA + sideB);
        }
        public override string ToString()
        {
            return $"{base.ToString()} прямоугольник со сторонами {sideA}, {sideB}";
        }
    }
}
