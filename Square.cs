
namespace ConsoleApp1
{
    public class Square : Rectangle
    {
        public Square(int sideA, int sideB) : base(sideA, sideB)
        {
            if (sideA != sideB) throw new ArgumentException("Стороны квадрата должны быть эквивалентны");
        }
        public override string ToString()
        {
            return $"{base.ToString()} - квадрат";    
        }
    }
}
