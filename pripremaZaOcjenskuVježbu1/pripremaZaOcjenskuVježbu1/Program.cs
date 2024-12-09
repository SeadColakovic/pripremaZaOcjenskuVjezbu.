using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaOcjenskuVježbu1
{
    internal class Program
    


    {
        static void Main()
        {
            int x, y, z;

            Console.WriteLine("Unesite dužinu stranice x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite dužinu stranice y:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite dužinu stranice z:");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z)
                {
                    Console.WriteLine("Stranice čine pravokutni trokut.");
                }
                else
                {
                    Console.WriteLine("Stranice ne čine pravokutni trokut.");
                }
            }
            else
            {
                Console.WriteLine("Sve stranice moraju biti veće od 0.");
            }
        }
    }

}
