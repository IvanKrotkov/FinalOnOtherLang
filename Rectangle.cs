
using System.Transactions;

namespace ConsoleApp1
{
    public class Rectangle : ShapeBase, Perimetrable
    {
        protected int sideA;
        protected int sideB;
        public Rectangle(int sideA,int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public override double Area()
        {
            return this.sideA * this.sideB;  
        }

        public double Perimetrable()
        {
            return 2*(this.sideA + this.sideB);
        }
        public override string ToString()
        {
            return $"{base.ToString()} прямоугольник со сторонами {this.sideA}, {this.sideB}";
        }
    }
}
