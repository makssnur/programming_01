using System;

namespace CSharpBasicTasks
{
    public class Calculator
    {
        // ЗАДАНИЕ 1: a в степени n (только умножение)
        public static long PowerByMultiplication(int a, int n)
        {
            if (n == 0) return 1;  // любое число в 0 степени = 1
            
            long result = 1;
            for (int i = 0; i < n; i++)
            {
                result = result * a;  // умножаем n раз
            }
            return result;
        }
        
        // ЗАДАНИЕ 2: преобразование числа
        public static int TransformNumber(int x)
        {
            if (x < 100)
            {
                throw new ArgumentException("Число должно быть не меньше 100");
            }
            
            string xStr = x.ToString();           // "121111"
            string withoutSecond = xStr.Remove(1, 1);  // "11111"
            char secondDigit = xStr[1];                // '2'
            string resultStr = withoutSecond + secondDigit; // "111112"
            
            return int.Parse(resultStr);
        }
    }
}
// Решение заданий 1 и 2
