using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчёт линейного уравнения:");
            Console.Write("Введите k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            LeanerEquation leanerEquation = new LeanerEquation(k, b);
            Console.Write(leanerEquation.Root());
            Console.ReadLine();

        }
    }
}
