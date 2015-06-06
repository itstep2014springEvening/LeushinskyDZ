using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverlode
{
    class Mathematic
    {
        // перегрузка метода (два параметра типа int) допускается!
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        // перегрузка метода (три параметра типа int) допускается!
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        // перегрузка метода (три параметра типа double) допускается!
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        // перегрузка метода (два параметра типа double, но тип возврата string) НЕ допускается!
        //public static string Sum(double a, double b)
        //{
        //    return (a + b).ToString();
        //}
    }
}
