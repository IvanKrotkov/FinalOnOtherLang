namespace ConsoleApp1.Infrastructure
{
    public class Square : Rectangle
    {
        public Square(int sideA) : base(sideA, sideA)
        {
        }
        public override string ToString()
        {
            return $"{base.ToString()} - квадрат";
        }
    }
}
