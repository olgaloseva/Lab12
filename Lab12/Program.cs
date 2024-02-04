using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        //Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
        //метод, определяющий длину окружности по заданному радиусу;
        //метод, определяющий площадь круга по заданному радиусу;
        //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки: ");
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double p = Circle.GetCircumference(radius);
            double s = Circle.GetAreaCircle(radius);
            bool isLocated = Circle.GetIsLocatedInCircle(x, y, radius);

            Console.WriteLine("Длина окружности равняется {0}", p);
            Console.WriteLine("Площадь круга равна {0}", s);
            if (isLocated)
            {
                Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит окружности");
            }

            Console.ReadKey();

        }
    }
}
