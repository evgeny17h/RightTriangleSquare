using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RightTriangle
    {
        public static double RightTriangleSquare(double a, double b, double c)
        {
            //проверим, является ли треугольник прямоугольным
            double max = 0;
            if (a > b)
                if (b >= c)
                    max = a;
                else
                    if (a > c)
                        max = a;
                    else
                        if (a < c)
                            max = c;
                        else
                            throw new Exception("the triangle is not right-angled!");
            else
                if (a < b)
                    if (b < c)
                        max = c;
                    else
                        if (c < b)
                            max = b;
                        else
                            throw new Exception("the triangle is not right-angled!");
                else
                    if (a < c)
                        max = c;
                    else
                        throw new Exception("the triangle is not right-angled!");

            double eps = 0.001;
            if (a == max)
                if (Math.Abs(a * a - b * b - c * c) > eps)
                    throw new Exception("triangle is not right-angled!");
            if (b == max)
                if (Math.Abs(b * b - a * a - c * c) > eps)
                    throw new Exception("triangle is not right-angled!");
            if (c == max)
                if (Math.Abs(c * c - a * a - b * b) > eps)
                    throw new Exception("triangle is not right-angled!");

            //вычислим площадь
            double s = 0;
            if (a == max)
                s = b * c / 2;
            if (b == max)
                s = a * c / 2;
            if (c == max)
                s = a * b / 2;
            return s;
        }
    }
}
