using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicrosoftTest
{
    public class Task1
    {
        public int Call(string s,int solution)
        {
           
            switch (solution)
            {
                case 1:
                   return Solution1(s);
                case 2:
                    return Solution2(s);
                default:
                    return 0;
            }
     
        }

        private int Solution1(string s)
        {
            /*               
                simple linq solution
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();

            List<char> list = new List<char>();
            list.AddRange(s);

            var listRes = list.GroupBy(x => x)
            .Where(g => g.Count() % 2 != 0)
            .Select(y => new { Element = y.Key, Counter = y.Count() % 2 })
            .ToList();      
            int res = listRes.Select(c => c.Counter).Sum();

            watch.Stop();
            PrintTime(watch.Elapsed);
            return res;
        }

        private int Solution2(string s)
        {
            /*               
                loop trough every second one to check every pair 
                if is not the same, set loop back to firs char and continue
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();


            List<char> list = new List<char>();
            list.AddRange(s);
            list = list.OrderBy(x => x).Reverse().ToList();
            char tempChar = '%';
            int res = 0;
            for (int i = 0; i < list.Count; i+=2)
            {
                if(list[i] != tempChar)
                {
                    if(i != 0 && list[i-1] != tempChar)
                    {
                        //i:: If prevous one was wrong one
                        res++;
                        i--; 
                    }
                    tempChar = list[i];
                }
            }
            if((list.Count -res) % 2 != 0) { res++; } //i:: check if one is left
            watch.Stop();
            PrintTime(watch.Elapsed);
            return res;
        }
        public void PrintTime(TimeSpan time)
        {
            Console.Write("Time: " + time);
        }
    }
}
