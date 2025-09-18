using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            //Az elemek bekérése egyesével
            //numbers[0] = int.Parse(Console.ReadLine());
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;

            //Az adatok bekérése ciklussal
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Kérem a(z) {i}. elemet: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
