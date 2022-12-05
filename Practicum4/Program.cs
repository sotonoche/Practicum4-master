using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum4
{
    internal class Program
    {
        static double f(double n, double m)
        {
            try
            {
                if (n == 0)
                    return m + 1;
                else
            if ((n != 0) && (m == 0))
                    return f(n - 1, 1);
                else
                    return f(n - 1, f(n, m - 1));
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Стек переполнен. Значение на выходе слишком большое!");
            }
            
        }
        
        static void Main(string[] args)
        {
            double m, n, res;

            while (true)
            {
                try
                {
                    Console.Write("Введите значение n: ");
                    n = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите значение m: ");
                    m = Convert.ToDouble(Console.ReadLine());
                    if(n < 0 || m < 0) throw new Exception("Введенные значения должны быть неотрицательными!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            res = f(n, m);
            Console.WriteLine($"Значение ф-ии Аккермана равно {res}");
        }
    }
}
