using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems ..........");
            /*...........................................................
             * choose an option to perform particular operation
             * .................................................*/
            Console.WriteLine("Enter Your Choice :");
            int options = Convert.ToInt32(Console.ReadLine());
            /*..............................................................
             * Choose options using switch case
             * ................................................*/
            switch (options)
            {
                 case 1:
                     Console.WriteLine("Fibonacci Series ......");
                     FibonacciSeries.FindFibonacciSeries();
                     break;
                case 2:
                    Console.WriteLine("PerfectNumber ......");
                    PerfectNumber.FindPerfectNumber();
                    break;
                case 3:
                    Console.WriteLine("PrimeNumber ......");
                    PrimeNumber.PrimeNumbers();
                    break;
                default:
                    break;
            }
        }
    }
}
