using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Lab2._4._2___;
class Program
{
    static void Main(string[] args)
    {
        Expression[] arr = new Expression[]{
            new Expression(8, 0, 8, 5),
            new Expression(1, 9, 5, 4),
            new Expression(6, 5, 100, 5),
        };

        for (int i = 0; i < 3; i++)
        {
            try
            {
                double result = arr[i].evaluate();
                Console.WriteLine($"Result: {result}");
            }
            catch (InvalidOperationException error) {
                Console.WriteLine($"Error: {error.Message}");
            }

        }
    }
}