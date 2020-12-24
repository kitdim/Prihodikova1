// Разобраться почему не выводится максимальное число 
using System;

namespace Prihodikova1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести три целых числа x, y, z."+
                              "Если хотя бы одно из них четное,"+
                              "то первому четному числу присвоить значение произведения этих чисел,"+
                              "если все числа четные, то определить среди них"+
                              "наибольшее и выдать его на печать.");

            Console.Write("x = "); var x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = "); var y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = "); var z = Convert.ToInt32(Console.ReadLine());
                                  var multiplication = x * y * z;
                                  int max;


            if (x % 2 == 0 && y % 2 == 0 && z % 2 == 0)
            {

                if (x > y && x > z)
                {
                    max = x;
                    Console.WriteLine($"Максимальное число равно x = {max}");
                }
                else if (y > x && y > z)
                {
                    max = y;
                    Console.WriteLine($"Максимальное число равно y = {max}");
                }
                else
                {
                    max = z;
                    Console.WriteLine($"Максимальное число равно z = {max}");
                }
            }

            else if (x % 2 == 0)
            {
                x = multiplication;
                Console.WriteLine($"x = {x}; y = {y}; z = {z}.");
            }
            else if (y % 2 == 0)
            {
                y = multiplication;
                Console.WriteLine($"x = {x}; y = {y}; z = {z}.");
            }
            else if (z % 2 == 0)
            {
                z = multiplication;
                Console.WriteLine($"x = {x}; y = {y}; z = {z}.");
            }            
            else
            {
                Console.WriteLine("Все числа нечетные");
            }
        }
    }
}
