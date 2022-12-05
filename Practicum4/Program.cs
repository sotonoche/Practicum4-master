using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum4
{
    internal class Program
    {
        static int f(int n, int m)
        {
            if (n == 0)
                    return m + 1;
                else
            if ((n != 0) && (m == 0))
                    return f(n - 1, 1);
                else
                    return f(n - 1, f(n, m - 1));  
        }
        
        static void Main(string[] args)
        {
            int m, n, res;
            
            while (true)
            {
                try
                {
                    Console.Write("Введите значение n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите значение m: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    if(n < 0 || m < 0) throw new Exception("Введенные значения должны быть неотрицательными!");
                    if (n > 3 && m > 11) throw new Exception("Значение n не может быть больше 3, а значение m не может быть больше 11, т.к. стек будет переполнен!");
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
