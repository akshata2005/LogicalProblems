using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public class FibonacciSeries
    {
        public static void FindFibonacciSeries()
        {
            /*..................................................
             * initialize three variables n1,n2,n3 and assign n1=0 and n2=1 as Fibonacci series require two values
             * .....................................................................*/
            int n1 = 0, n2 = 1, n3;
            Console.WriteLine("Enter a number to find Fibonacci Series :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < num; i++)
            {
                /*..........................................................
                 * Store the sum of n1 & n2 in n3 and print n3
                 * repeat the below process until i reaches n
                 * .................................................*/
                n3 = n1 + n2;
                Console.Write(n3 + ",");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
