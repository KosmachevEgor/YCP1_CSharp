using System;
using static System.Math;

namespace YCP1_CSharp_
{
    class Program
    {
        static double G, H, R, M, S;
        private static void CONST()
        {
          G = 6.674088e-11;
        }
        private static void GetData()
        {
            Console.WriteLine("Введите массу планеты: ");
             M = Convert.ToDouble(Console.ReadLine());
             M = M * 10e+23;
            Console.WriteLine("Введите радиус планеты: ");
             R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту на которой расположен объект: ");
             H = Convert.ToDouble(Console.ReadLine());
        }
        private static void Result()
        {
         S = Convert.ToDouble(Math.Sqrt((G * M) / (H + R)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Масса планеты будет умножена на 10е+23");
            CONST();
            GetData();
            Result();
            Console.WriteLine("Скорость тела: ");
            Console.WriteLine(S);
        }
    }
}
