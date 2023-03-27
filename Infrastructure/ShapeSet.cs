
using System.Collections;

namespace ConsoleApp1.Infrastructure
{
    public class ShapeSet
    {
        private List<ShapeBase> shapeList;
        public ShapeSet(List<ShapeBase> shapes)
        {
            shapeList = shapes;
        }
        public void addShape(ShapeBase shape)
        {
            shapeList.Add(shape);
        }
        public void removeShape(int index)
        {
            shapeList.RemoveAt(index);
        }
        public void Print()
        {
            for (int i = 0; i < shapeList.Count; i++)
            {
                Console.WriteLine(shapeList[i]);
            }
        }
    }
}
