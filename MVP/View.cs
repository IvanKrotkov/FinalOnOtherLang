using ConsoleApp1.Infrastructure;

namespace ConsoleApp1.MVP
{
    interface View
    {
        void GetMenu(ShapeSet shapeSet);
        void SetDataUser(ShapeSet shapeSet);

        void SetShape(ShapeSet shapeSet);
        int[] Reader(int temp);
        int[] GetArray(int lenght);
    }
}
