using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030.kettoszamkozulanagyobbik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            if (szam1 > szam2)
                Console.WriteLine("A nagyobbik szám: " + szam1 + "." + "\n");

            else
                Console.WriteLine("A nagyobbik szám: " + szam2 + "." + "\n");

            Console.ReadKey();
        }

    }
}
