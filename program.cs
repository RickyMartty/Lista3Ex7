using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p;
            int d, v;
            p = Console.ReadLine();
            for (v = 1; v <= 20; v++)
            {
                for (int i = 1; i < 11; i++)
                {
                    d = v * i;
                    Console.WriteLine($"{v} x {i} = {d}");

                }
                Console.WriteLine("Pressione uma tecla...");
                p = Console.ReadLine();
            }
        }
    }
}
