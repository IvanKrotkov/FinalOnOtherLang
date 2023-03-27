using ConsoleApp1.Infrastructure;

namespace ConsoleApp1.MVP
{
    public class Presenter : View
    {
        private Model model;
        private void SettingDefaultShapes()
        {
            model = new Model(new ShapeSet(ShapeSetCreater()));
        }
        private List<ShapeBase> ShapeSetCreater()
        {
            List<ShapeBase> shapes = new List<ShapeBase>();
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Square(4));
            shapes.Add(new Rectangle(4, 5));
            shapes.Add(new Circle(5));
            return shapes;
        }
        public void Start()
        {
            SettingDefaultShapes();
            GetMenu(model.ShapeSet);
        }

        public void GetMenu(ShapeSet shapeSet)
        {
            Console.WriteLine("1 - Показать множество фигур\n" +
                              "2 - Добавить фигуру\n" +
                              "3 - Удалить фигуру\n" +
                              "4 - Выход");
            SetDataUser(shapeSet);
        }

        public void SetDataUser(ShapeSet shapeSet)
        {
            {
                int temp = int.Parse(Console.ReadLine());
                if (temp == 1)
                {
                    shapeSet.Print();
                    GetMenu(shapeSet);
                }
                else if (temp == 2)
                {
                    Console.WriteLine("Какую фигуру добавить?\n" +
                                       "1 - Круг\n" +
                                       "2 - Прямоугольник\n" +
                                       "3 - Квадрат\n" +
                                       "4 - Треугольник\n" +
                                       "5 - Назад");
                    SetShape(shapeSet);
                }
                else if (temp == 3)
                {
                    removeShape();
                    GetMenu(shapeSet);
                }
                else
                {
                    return;
                }
            }
        }
        public void removeShape()
        {
            Console.WriteLine("Введите индекс:");
            int index = int.Parse(Console.ReadLine());
            model.removeEl(index);
        }
        public void SetShape(ShapeSet shapeSet)
        {
            int temp = int.Parse(Console.ReadLine());
            if (temp == 1)
            {
                Console.WriteLine("Укажите радиус");
                int radius = int.Parse(Console.ReadLine());
                shapeSet.addShape(new Circle(radius));
                GetMenu(shapeSet);

            }
            else if (temp == 2)
            {
                int[] sides = Reader(temp);
                shapeSet.addShape(new Rectangle(sides[0], sides[1]));
                GetMenu(shapeSet);

            }
            else if (temp == 3)
            {
                Console.WriteLine("Введите сторону квадрата:");
                int sideA = int.Parse(Console.ReadLine());
                shapeSet.addShape(new Square(sideA));
                GetMenu(shapeSet);
            }
            else if (temp == 4)
            {
                int[] sides = Reader(temp);
                shapeSet.addShape(new Triangle(sides[0], sides[1], sides[2]));
                GetMenu(shapeSet);
            }
            else
            {
                GetMenu(shapeSet);
            }
        }
        public int[] Reader(int temp)
        {
            if (temp == 2)
            {
                return GetArray(2);
            }
            else
            {
                return GetArray(3);
            }
        }
        public int[] GetArray(int lenght)
        {
            int[] res = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Введите сторону: ");
                int sideA = int.Parse(Console.ReadLine());
                res[i] = sideA;
            }
            return res;
        }
    }
}
