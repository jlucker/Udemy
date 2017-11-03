using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    partial class Program
    {
        
        static void Main(string[] args)
        {
            // var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion Fialed");
            Console.ReadLine();

        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);

                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error has occured");
                Console.ReadLine();
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
            Console.ReadLine();
        }
    }
}
