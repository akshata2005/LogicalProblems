using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public class Coupon
    {
        public static void CouponNumbers()
        {
            /*....................................................
             * initialize start range and peak range and couponcount variables
             * ...................................................*/
            int peakRange, lowRange, coupon, couponCount = 0;

            Console.WriteLine("Enter lower range of Coupon Number : ");
            lowRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Peak range of Coupon Number : ");
            peakRange = Convert.ToInt32(Console.ReadLine());

            HashSet<int> list = new HashSet<int>();

            Random rand = new Random();

            while (list.Count <= Math.Abs(lowRange - peakRange))
            {
                coupon = rand.Next(lowRange, peakRange + 1);
                couponCount++;
                list.Add(coupon);
            }
            Console.WriteLine("The distinct coupon numbers are : ");
            foreach (int i in list)
            {
                Console.Write(i + ", ");
            }


            Console.WriteLine("We need " + couponCount + " Random operations to generate coupons in the given range ");
        }
    }

}
