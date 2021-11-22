using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StarString = Console.ReadLine();
            string Words = " ";
            for (int i = StarString.Length - 1; i >= 0; i--)
            {
                Words += StarString[i];
            }
                if (StarString == Words)
                    Console.WriteLine("Палиндром");
                 else
                    Console.WriteLine("Не палиндром");
                Console.ReadKey();
        }
    }
}
