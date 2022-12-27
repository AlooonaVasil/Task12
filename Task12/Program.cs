using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности ");
            var r = Convert.ToDouble(Console.ReadLine());
            var length = Circle.GetLength(r);
            var square = Circle.GetSquare(r);
            Console.WriteLine($"Длина окружности = {length:f2} \nПлощадь круга = {square:f2}");
            Console.WriteLine();

            Console.WriteLine("Введите координаты центра круга (x0 и y0)");
            var x0 = Convert.ToDouble(Console.ReadLine());
            var y0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки (x и y)");
            var x = Convert.ToDouble(Console.ReadLine());
            var y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Circle.PointStatus(x, y, x0, y0, r));
            Console.ReadKey();
        }
    }
}
