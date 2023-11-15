using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispit03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj, rez = 0, x = 1, y = 0;
            Console.WriteLine("Upisite broj ");
            broj = Convert.ToInt32(Console.ReadLine());
            if(broj == 0) 
            {
                Console.WriteLine("Rezultat je 0 ");
            }
            if (broj == 1)
            {
                Console.WriteLine("Rezultat je 1 ");
            }
            if (broj > 1)
            {
                for (int i = 0; i < broj; i++)
                {
                    for (int j = 1; j < broj; j++)
                    {
                        rez = x + y;
                        y = x;
                        x = rez;
                    }
                }
            }
            Console.WriteLine("Rezultat Fibanoccijevog niza je " + rez);
            Console.ReadKey();
        }
    }
}
