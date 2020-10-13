using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicrosoftTest
{
    public class Task2
    {
        public int Call(int[] ints, int type)
        {


            switch (type)
            {
                case 1:
                    return Solution1(ints);
                case 2:
                   return  Solution2(ints);
                case 3:
                    return Solution3(ints);
                default:
                    return 0;
            }

        }

        private int Solution1(int[] ints)
        {
            /*               
                simple linq solution
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();

            var query = ints.GroupBy(x => x)
              .Where(g => g.Count() == g.Key)
              .OrderBy(i => i.Count()).LastOrDefault();

            watch.Stop();
            PrintTime(watch.Elapsed);
            return query == null ? 0 : query.Key;

        }       


        private int Solution2(int[] ints)
        {
            /*               
                sort list reverse and loop through items, 
                save current item as n and count next items, if we get it n times and next one is different
                then we have correct number
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();

            int tempInt = 0;
            int tempCount = 0;
            foreach (int item in ints.OrderBy(x => x).Reverse().ToList())
            {
                if (item != tempInt)
                {
                    if (tempCount != 0 && tempCount == tempInt)
                    {
                        //i switched to new number but last one was exactly what we looking for 
                        watch.Stop();
                        PrintTime(watch.Elapsed);
                        return tempCount;
                    }
                    tempInt = item;
                    tempCount = 1;
                }
                else
                {
                    tempCount++;
                }
            }
            watch.Stop();
            PrintTime(watch.Elapsed);
            return tempCount == tempInt ? tempCount : 0;
        }

        private int Solution3(int[] ints)
        {
            /*               
                sort list reverse and loop through items, 
                for every item n check do we have the same number on list[n] and 
                different on list[n + 1] , what would mean we have n numbers on n
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();

            int tempInt1 = 0;

            ints = ints.OrderBy(x => x).Reverse().ToArray();
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] != tempInt1)
                {
                    tempInt1 = ints[i];
                    if (ints.Length >= i + tempInt1)
                    {
                        //i have enought items to check if we have same items until position where it need to bee
                        if (ints[i + tempInt1 - 1] == tempInt1)
                        {
                            //i we have the same item on exact position
                            if (ints.Length == i + tempInt1 || (ints.Length >= i + tempInt1 + 1 && ints[i + tempInt1] != tempInt1))
                            {
                                //i next item is different so we have exact n instances on n
                                watch.Stop();
                                PrintTime(watch.Elapsed);
                                return tempInt1;
                            }

                        }
                    }
                }

            }

            watch.Stop();
            PrintTime(watch.Elapsed);
            return 0;

        }


        public void PrintTime(TimeSpan time)
        {
            Console.Write("Time: " + time);
        }
    }
}
