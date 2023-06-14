using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_17_siesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int div;

            Console.WriteLine("Favor ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Favor ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            
            div = num1 / num2;

            Console.WriteLine($"la division de los dos numero es: {div}");

            Console.ReadKey();
        }
    }
}
