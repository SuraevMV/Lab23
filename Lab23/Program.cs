using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для расчета факториала");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintAsync(n);
            Console.ReadKey();
            

        }
        static int Factorial(int n)
        {
            Console.WriteLine("Начало метода Factorial");
            int factorial = 1;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    factorial = factorial * (i + 1);
                }
                Console.WriteLine("Конец метода Factorial");
                return factorial;
            }
            else
            {
                Console.WriteLine("Введено некоректное число");
                Console.WriteLine("Конец метода Factorial");
                return factorial = 0;
            }
        }
        static async Task<int> PrintAsync(int n)
        {
            Console.WriteLine("Начало метода PrintAsync");
            int result = await Task.Run(() => Factorial(n));
            if (result != 0)
            {
                Console.WriteLine("Факториал числа {0} равен {1}", n, result);
            }
            Console.WriteLine("Конец метода PrintAsync");
            return result;
        }
    }
}
