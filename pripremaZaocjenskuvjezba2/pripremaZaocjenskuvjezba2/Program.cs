﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaocjenskuvjezba2
{
    internal class Program
    

    {
        static void Main()
        {
            for (int year = 1900; year <= 2100; year++)
            {
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    Console.WriteLine(year);
                }
            }
        }
    }

}
