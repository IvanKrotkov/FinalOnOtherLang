namespace ConsoleApp1.Infrastructure
{
    public class Triangle : ShapeBase, Perimetrable
    {
        int sideA, sideB, sideC;
        public Triangle(int side1, int side2, int side3)
        {
            if (side1 + side2 < side3 |
                side1 + side3 < side2 |
                side2 + side3 < side1) throw new Exception("Такого треугольника не существует");
            sideA = side1;
            sideB = side2;
            sideC = side3;
        }
        public override double Area()
        {
            double semiPerimter = Perimetrable() / 2;
            return Math.Sqrt(semiPerimter * (semiPerimter - sideA) * (semiPerimter - sideB) * (semiPerimter - sideC));
        }
        public double Perimetrable()
        {
            return sideA + sideB + sideC;
        }
        public override string ToString()
        {
            return $"{base.ToString()} треугольник со сторонами {sideA},{sideB},{sideC}";
        }
    }

}
