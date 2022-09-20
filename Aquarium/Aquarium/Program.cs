using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[0, 0] aquarium = new string[10, 10];

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; 1 < 10; i++)
                {
                    aquarium[i, j] = "a";
                }
            }
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; 1 < 10; i++)
                {
                    Console.Write(aquarium[i, j]);
                }
                Console.Write("\n");
            }

            Console.ReadLine();





        }
    }
}
