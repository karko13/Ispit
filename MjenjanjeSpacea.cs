using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite neku recenicu koju zelite izmjeniti ");
            string recenica = Console.ReadLine();
            Console.WriteLine(recenica.Replace(" ", "_"));
            Console.ReadKey();
        }
    }
}
