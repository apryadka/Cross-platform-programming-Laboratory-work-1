using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            List<double> inputTriangle = initTriangle();
            double result = Сalculation.Сalculation.findSideOfTriangle(inputTriangle[0], inputTriangle[1]);

            if (result.Equals(-1))
            {
                Console.WriteLine("Неверные данные поробуй еще!");
                inputTriangle.Clear();
                inputTriangle.AddRange(initTriangle());
                result = Сalculation.Сalculation.findSideOfTriangle(inputTriangle[0], inputTriangle[1]);

            }
            Console.WriteLine($"Длина неизвестных сторон треугольника равна : {result}");

            Console.WriteLine("\nЗадание 2");
            List<double> inputSumOfmembersSeries = initfindSumOfmembersSeries();
            result = Сalculation.Сalculation.findSumOfmembersSeries((int)inputSumOfmembersSeries[0], inputSumOfmembersSeries[1]);
            
            if (result.Equals(-1))
            {
                Console.WriteLine("Неверные данные поробуй еще!");
                inputSumOfmembersSeries.Clear();
                inputSumOfmembersSeries.AddRange(initfindSumOfmembersSeries());
                result = Сalculation.Сalculation.findSideOfTriangle(inputTriangle[0], inputTriangle[1]);

            }
            Console.WriteLine($"S = {result}");

            Console.WriteLine("\nЗадание 3");
            List<double> inputExactSumOfmembersSeries = initfindSumOfmembersSeries();
            result = Сalculation.Сalculation.findExactlySumOfmembersSeries((int)inputExactSumOfmembersSeries[0], inputExactSumOfmembersSeries[1]);

            if (result.Equals(-1))
            {
                Console.WriteLine("Неверные данные поробуй еще!");
                inputExactSumOfmembersSeries.Clear();
                inputExactSumOfmembersSeries.AddRange(initTriangle());
                result = Сalculation.Сalculation.findExactlySumOfmembersSeries((int)inputExactSumOfmembersSeries[0], inputExactSumOfmembersSeries[1]);

            }
            Console.WriteLine($"T = {result}");



        }
        // Secondary functions
        static double aDouble(string numberToString) 
        {
            double number;
            while (!double.TryParse(numberToString, out number))
            {
                Console.Write("Введите число!\n ->");
                numberToString = Console.ReadLine();
            }
            return number;

        }

        static int aInt(string numberToString)
        {
            int number;
            while (!int.TryParse(numberToString, out number))
            {
                Console.Write("Введите число!\n ->");
                numberToString = Console.ReadLine();
            }
            return number;

        }

        static List<double> initTriangle()
        {
            Console.WriteLine("Значение периметра : ");
            double P = aDouble(Console.ReadLine());
            Console.WriteLine("Значение длины известной стороны : ");
            double A = aDouble(Console.ReadLine());
            return new List<double> { P, A };

        }

        static List<double> initfindSumOfmembersSeries()
        {
            Console.WriteLine("Количество итерацый : ");
            int n = aInt(Console.ReadLine());
            Console.WriteLine("Значение периметра x : ");
            double x = aDouble(Console.ReadLine());
            return new List<double> { n, x };

        }
    }
}
