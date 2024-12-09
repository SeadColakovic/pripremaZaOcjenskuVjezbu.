using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaocjenksuvjezbu4
{
  
    class KlasaX
    {
        private int broj = 10;

        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KlasaX instanca = new KlasaX();
            Console.WriteLine(instanca.Broj);
        }
    }

}
