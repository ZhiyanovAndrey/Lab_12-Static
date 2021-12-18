using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
    -метод, определяющий длину окружности по заданному радиусу;
    -метод, определяющий площадь круга по заданному радиусу;
    -метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0. */

namespace Lab_12_Static
{
    static class Circle
    {
        public static double x;
        public static double y;
        public static double r;

        //Методы статического класса
        public static double ToLengthOfCircle()
        {
            double l = 2 * Math.PI * r;
            return l;
        }
        public static double ToSquareOfCircle()
        {
            double S = Math.PI * Math.Pow(r, 2);
            return S;
        }
        public static void BelongToCircle()
        {
            double Gip = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("Расстояние до центра круга: {0:F3}", Gip);
            if (Gip >= r) Console.WriteLine("Точка ({0},{1}) принадлежит кругу с радиусом {2}", x, y, r);
            else Console.WriteLine("Точка ({0},{1}) не принадлежит кругу с радиусом {2}", x, y, r);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            Double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус окружности");
            Double c = Convert.ToDouble(Console.ReadLine());
            Circle.x = a;
            Circle.y = b;
            Circle.r = c;
            Console.WriteLine("Длина окружности {0:F3}", Circle.ToLengthOfCircle());
            Console.WriteLine("Площадь окружности {0:F3}", Circle.ToSquareOfCircle());
            Circle.BelongToCircle();
            Console.ReadKey();
        }
    }
}
