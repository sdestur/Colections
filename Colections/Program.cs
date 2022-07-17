using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "engin", "murat", "halil" , "ayaz"};
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            

            List<string> names2 = new List<string> {"Engin" , "Murat" , "Halil" , "Kerem" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("ikler");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[3]);

        }
    }
}
