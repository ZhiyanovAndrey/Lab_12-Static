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
        const double r;

        //Методы класса
        public static double ToLengthOfCircle()
        {
            double l = 2 * Math.PI*r;
            return l;
        }
        public static double ToSquareOfCircle()
        {
            double S = Math.PI * Math.Pow(r, 2);
            return S;
        }
        public static double ToCircle()
        {
            double S = Math.PI * Math.Pow(r, 2);
            return S;
        }



        //Параметризированный конструктор для классса.
        public Gradus(int grad, int min, int sec)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            int r = Convert.ToInt32(Console.ReadLine());
            Gradus gradus = new Gradus(a, b, c);
            double radian = gradus.ToRadian();
            Console.WriteLine("Число {0}.{1}.{2} равно {3:F5} радиан", a, b, c, radian);
            Console.ReadKey();
        }
    }
}
