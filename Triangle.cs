
namespace ConsoleApp1
{
    public class Triangle : ShapeBase, Perimetrable
    {
        int sideA, sideB, sideC;
        public Triangle(int side1, int side2, int side3)
        {
            if (side1 + side2 < side3 |
                side1 + side3 < side2 |
                side2 + side3 < side1) throw new Exception("Такого треугольника не существует");
            this.sideA = side1;
            this.sideB = side2;
            this.sideC = side3;
        }
        public override double Area()
        {
            double semiPerimter = Perimetrable() / 2;
            return Math.Sqrt(semiPerimter * (semiPerimter - this.sideA) * (semiPerimter - this.sideB) * (semiPerimter - this.sideC));
        }
        public double Perimetrable()
        {
            return this.sideA + this.sideB + this.sideC;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - треугольник со сторонами {this.sideA},{this.sideB},{this.sideC}";
        }
    }

}
