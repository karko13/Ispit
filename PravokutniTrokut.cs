using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    internal class Program
    {
        static void Main(string[] args)
        {
   mjau:    Console.WriteLine("Upisite stranice pravokutnog trokuta odvojene razmakom ");
            string x = Console.ReadLine();
            int a = Convert.ToInt32(x.Split(' ')[0]);
            int b = Convert.ToInt32(x.Split(' ')[1]);
            int c = Convert.ToInt32(x.Split(' ')[2]);
            Console.WriteLine("Prvi broj je " + a + " drugi broj je " + b + " treci broj je " + c);
            if(c < a || c < b) 
            {
                Console.WriteLine(" treca stranica to jest hipotenuza mora biti najveca ");
                goto mjau;
            }
            else
            { 
                if ((c*c) == (a*a) + (b*b))
                {
                    Console.WriteLine("Trokut je pravokuta BRAVO");

                }
                else
                {
                    Console.WriteLine("Trokut nije pravokutan");
                }
            }
            Console.ReadKey();
        }
    }
}
