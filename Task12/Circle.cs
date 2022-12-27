using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    static class Circle
    {
        public static double GetLength(double r)
        {
            return (2 * Math.PI * r);
        }
        public static double GetSquare(double r)
        {
            return (Math.PI * Math.Pow(r, 2));
        }
        public static string PointStatus(double x, double y, double x0, double y0, double r)
        {
            var d = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
            return d < r ? "Точка принадлежит кругу" : d == r ? "Точка на окружности" : "Точка вне круга";
        }
    }
}
