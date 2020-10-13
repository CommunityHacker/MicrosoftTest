using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicrosoftTest
{
    public class Task3
    {
        public int Call(int[] A, int K, int solution)
        {

            switch (solution)
            {
                case 1:
                    return Solution1(A,K);
                case 2:
                    return Solution2(A, K);
                default:
                    return 0;
            }

        }

        private int Solution1(int[] A, int K)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (A.Length < K) { return -1; }
            Array.Sort(A);
            int[] startArray = A.Skip(Math.Max(0, A.Count() - K)).ToArray(); // TODO :: need math ?
            if (startArray.Sum() % 2 != 0)
            {
                foreach (int item in startArray)
                {
                    for (int i = A.Length - (K + 1); i >= 0; i--)
                    {
                        if (((startArray.Sum() - item) + A[i]) % 2 == 0)
                        {
                            int res = (startArray.Sum() - item) + A[i]; //i:: Cache data for Stopwatch
                            return res;
                        }
                    }
                }
            }
            else
            {
                return startArray.Sum();
            }
            return -1;
        }

        private int Solution3(int[] A, int K)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (A.Length < K) { return -1; }
            Array.Sort(A);
            int[] biggestArray = A.Skip(Math.Max(0, A.Count() - K)).ToArray();
            int[] restArray = A.Except(biggestArray).ToArray();

            int biggestSum = biggestArray.Sum();
            if (biggestSum % 2 != 0) {

                if(K % 2 != 0)
                {
                    //i:: remove smallest number and find other one

                    if (biggestArray[biggestArray.Length - 1] % 2 == 0)
                    {   //i:: removed number is even so add biggest odd number
                        return biggestArray.SkipLast(1).Sum() + restArray.OrderBy(x => x).Where(x => x % 2 != 0).FirstOrDefault();
                    }
                    else
                    { //i:: removed number is odd so add biggest even number
                        return biggestArray.SkipLast(1).Sum() + restArray.OrderBy(x => x).Where(x => x % 2 == 0).FirstOrDefault();
                    }

                }
                else
                {

                }
            }
            else
            {
                return biggestArray.Sum();
            }
           
            return -1;
        }

        private int Solution2(int[] A, int K)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (A.Length < K) { return -1; }
            Array.Sort(A);

            int[] biggestArray = A.Skip(A.Length - K).ToArray();


            int tempSum = biggestArray.Sum();

            if (tempSum % 2 == 0)
            {
                return tempSum;
            }

            int[] restArray = A.Take(A.Length - K).ToArray();
            int bSmallestOdd = biggestArray.Where(x => x % 2 != 0).FirstOrDefault();
            int bSmallestEven = biggestArray.Where(x => x % 2 == 0).FirstOrDefault();
            int rBiggestOdd = restArray.Where(x => x % 2 != 0).LastOrDefault();
            int rBiggestEven = restArray.Where(x => x % 2 == 0).LastOrDefault();

            if (rBiggestOdd == 0) { // No odd numbers in result              
                if(rBiggestEven == 0) { return -1; } // No even numbers in result
                return tempSum - bSmallestOdd + rBiggestEven;   // remove odd and add biggest even
            }

            if(rBiggestEven == 0) // No even numbers in result
            {
                //remove smallest even and add biggest odd
                if (rBiggestOdd == 0) { return -1; } // No odd numbers in result
                if(bSmallestEven == 0) { return -1; } // eather in biggest array and result there is even numbers
                return tempSum - bSmallestEven + rBiggestOdd;
            }

            if (bSmallestEven == 0)  
            {
                return tempSum - bSmallestOdd + rBiggestEven;
            }

            int result = 0;

            if(bSmallestOdd + rBiggestOdd > bSmallestEven + rBiggestEven)
            {
                result = tempSum - bSmallestEven + rBiggestOdd;
            }
            else
            {
                result = tempSum - bSmallestOdd + rBiggestEven;
            }


            if (bSmallestOdd + rBiggestEven > bSmallestEven + rBiggestOdd)
            {
                return result >= tempSum - bSmallestOdd + rBiggestEven ? result : tempSum - bSmallestOdd + rBiggestEven;
            }
            else
            {
                return result >= tempSum - bSmallestEven + rBiggestOdd ? result : tempSum - bSmallestEven + rBiggestOdd;
            }

        }


        public void PrintTime(TimeSpan time)
        {
            Console.Write("Time: " + time);
        }
    }

   
}
