using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Add(2,3));

            Calculator calculator1 = new Calculator();

            calculator1.Subtract(2,3);

            Console.WriteLine(calculator1.Subtract(2,7);
        }
    }
}
