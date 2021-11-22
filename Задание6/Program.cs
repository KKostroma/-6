using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StarString = Console.ReadLine(); 
            string[]Words = StarString.Split();
            int max = 0;
            foreach (string s in Words)
            {
                if (s.Length > max)
                    max = s.Length;
            }
                Console.Write("Самое длинное слово: {0}", max);
                Console.ReadKey();
        }
    }
}
