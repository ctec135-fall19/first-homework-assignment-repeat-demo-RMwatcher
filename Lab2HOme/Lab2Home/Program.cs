using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Home
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Let a look here to see what we see below");
            Console.WriteLine();

            SportsCar myCar = new SportsCar();
            Console.WriteLine("Here comes the {0}", myCar.GetPetName());
        }
    }
}
