using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChef
{
    public class CHEFARRP : Run
    {
        int n;
        int[] a;
        public void run()
        {
            n = Convert.ToInt32(Console.ReadLine());
            a = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int result = solve(n, a);
            Console.WriteLine(result);
        }

        private int solve(int n, int[] a)
        {
            //At least all individual elements form a subarray where 
            //subarray sum is equal to subarrya product
            int result = 0;

            //These will hold sum and product of elements , of subarray
            //seen so far
            int total_sum = 0;
            int total_prod = 1;

            //loop for subarrays

            //start with subarray starting at first element,
            //then second element, and so forth...
            for (int i = 0; i < n; i++)
            {
                //reset sum and product at each iteration
                total_sum = 0;
                total_prod = 1;

                //loop for subarray starting at ith element
                for (int j = i; j < n; j++)
                {
                    total_sum += a[j];
                    total_prod *= a[j];

                    //Increment the result count if our requirement has been met.
                    if (total_sum == total_prod)
                        result++;
                }
            }
            return result;
        }
    }
}
