using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum4_Task2
{
    internal class Program
    {
        static void rec(int i)
        {
            if (i == 0)
                return;
            else
                Console.Write(i + " ");
                rec(i - 1);
        }

        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                try
                {
                    Console.Write("Введите значение n: ");
                    n = int.Parse(Console.ReadLine());
                    if(n < 1000) throw new Exception("Число не может быть меньше 1000!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введены некорректные значения!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
            rec(n);

        }
    }
}
