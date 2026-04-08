using System;

namespace CSharpBasicTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // == ЗАДАНИЕ 1 ==
            Console.WriteLine(" Задание 1: Вычисление a^n ");
            Console.Write("Введите основание a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите степень n: ");
            int n = int.Parse(Console.ReadLine());
            
            long result = Calculator.PowerByMultiplication(a, n);
            Console.WriteLine($"{a}^{n} = {result}");
            
            // == ЗАДАНИЕ 2 ==
            Console.WriteLine("\n Задание 2: Преобразование числа ");
            Console.Write("Введите число x (x >= 100): ");
            int x = int.Parse(Console.ReadLine());
            
            int nResult = Calculator.TransformNumber(x);
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"n = {nResult}");
            
            // Проверка примера из задания
            if (x == 121111)
            {
                Console.WriteLine($"\n✅ ПРОВЕРКА: 121111 → {nResult} (должно быть 111112)");
            }
        }
    }
}
