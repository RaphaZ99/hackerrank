using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Exercicies.Dia1
{
    public class MinMaxSum
    {
        /*
         Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. 
        Then print the respective minimum and maximum values as a single line of two space-separated long integers.
        Example : arr[1,3,5,7,9]
        The minimum sum is 1 + 3 + 5 + 7 = 16  and the maximum sum is 3,5,7,9 = 24 . The function prints 17 24
         
         */
        public static void miniMaxSum(List<int> arr)
        {

            var orderByAscending = arr.OrderBy(x => x).ToList();
            var orderByDescending = arr.OrderByDescending(x => x).ToList();
            var count = 0;
            long somaMenor = 0;
            long somaMaior = 0;

            foreach (int i in orderByAscending)
            {
                if (count >= 4)
                {
                    count = 0; continue;
                }
                somaMenor += i;
                count++;

            }
            foreach (int i in orderByDescending)
            {
                if (count >= 4)
                {
                    count = 0; continue;
                }
                somaMaior += i;
                count++;
            }

            Console.WriteLine($"{somaMenor} {somaMaior}");
        }
    }
}
