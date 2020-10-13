using System;
using System.Collections.Generic;
using System.Linq;

namespace MicrosoftTest
{
    class Program
    {

        /*
            Only way to make it fester then Linqu is to cut down looping 


         */


        static void Main(string[] args)
        {
            TaskType taskType = TaskType.Task3;

            for (int i = 0; i < 10; i++)
            {
                switch (taskType)
                {
                    case TaskType.Task1:
                        RunTask1();
                        break;
                    case TaskType.Task2:
                        RunTask2();
                        break;
                    case TaskType.Task3:
                        RunTask3();
                        break;
                    default:
                        break;
                }
            }
           


            #region Test 3


            //int i2 = test3(new int[] { 4, 9, 8, 2, 6 }, 3);
            //int i3 = test3(new int[] { 5, 6, 3, 4, 2 }, 5);
            //int i4 = test3(new int[] { 7, 7, 7, 7, 7 }, 1);
            //int i5 = test3(new int[] { 1000000 }, 2);
            //int i6 = test3(new int[] { 2, 3, 3, 5, 5 }, 3);
            //int i7 = test3(new int[] { 2, 3, 3, 5, 5 }, 3);
            //int i8 = test3(new int[] { 0 }, 3);
            //int i9 = test3(new int[] { 0, 0, 0, 0, }, 3);
            //Console.WriteLine(i2);
            //Console.WriteLine(i3);
            //Console.WriteLine(i4);
            //Console.WriteLine(i5);
            //Console.WriteLine(i6);
            //Console.WriteLine(i7);
            //Console.WriteLine(i8);
            //Console.WriteLine(i9);
            #endregion
        }

        private static void RunTask1()
        {
            Task1 task1 = new Task1();
            int solution = 1;

            // Test Case 1

            PrintStart(1, 1, solution);
            PrintResult(task1.Call("acbcbba", solution), 1);

            solution = 2;

            PrintStart(1, 1, solution);
            PrintResult(task1.Call("acbcbba", solution), 1);

            // Test Case 2

            solution = 1;

            PrintStart(1, 2, solution);
            PrintResult(task1.Call("axxaxa", solution), 2);

            solution = 2;

            PrintStart(1, 2, solution);
            PrintResult(task1.Call("axxaxa", solution), 2);

            // Test Case 3

            solution = 1;

            PrintStart(1, 3, solution);
            PrintResult(task1.Call("aaaa", solution), 0);

            solution = 2;

            PrintStart(1, 3, solution);
            PrintResult(task1.Call("aaaa", solution), 0);

            // Test Case 4

            solution = 1;
            string tempString = "";
            char[] chars = new char[] { 'a','b', 'c', 'd', 'e', 'f', 'g', 'h', 'e', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's','t','u' };
            for (int i = 0; i < 10000; i++)
            {
                foreach (char item in chars)
                {
                    tempString += item;
                }
            }
            tempString += "aaaaaa";
            tempString += "bb";
            tempString += "ltac"; //i:: Result is count of those

            Random r = new Random();

            tempString = new String(tempString.ToCharArray().ToList().OrderBy(x => r.Next()).ToArray());
            PrintStart(1, 4, solution);
            PrintResult(task1.Call(tempString, solution), 4);

            solution = 2;

            PrintStart(1, 4, solution);
            PrintResult(task1.Call(tempString, solution), 4);
        }

        private static void RunTask2()
        {

            Task2 task2 = new Task2();
            int solution = 1;

            // Test Case 1

            PrintStart(2, 1, solution);
            int i1 = task2.Call(new int[] { 3, 1, 4, 1, 5 }, solution);
            PrintResult(i1, 0);

            solution = 2;

            PrintStart(2, 1, solution);
            i1 = task2.Call(new int[] { 3, 1, 4, 1, 5 }, solution);
            PrintResult(i1, 0);

            solution = 3;

            PrintStart(2, 1, solution);
            i1 = task2.Call(new int[] { 3, 1, 4, 1, 5 }, solution);
            PrintResult(i1, 0);


            // Test Case 2

            solution = 1;

            PrintStart(2, 2, solution);
            int i2 = task2.Call(new int[] { 7, 1, 2, 8, 2 }, solution);
            PrintResult(i2, 2);

            solution = 2;

            PrintStart(2, 2, solution);
            i2 = task2.Call(new int[] { 7, 1, 2, 8, 2 }, solution);
            PrintResult(i2, 2);

            solution = 3;

            PrintStart(2, 2, solution);
            i2 = task2.Call(new int[] { 7, 1, 2, 8, 2 }, solution);
            PrintResult(i2, 2);

            // Test Case 3

            solution = 1;

            PrintStart(2, 3, solution);
            int i3 = task2.Call(new int[] { 5, 5, 5, 5, 5 }, solution);
            PrintResult(i3, 5);

            solution = 2;

            PrintStart(2, 3, solution);
            i3 = task2.Call(new int[] { 5, 5, 5, 5, 5 }, solution);
            PrintResult(i3, 5);

            solution = 3;

            PrintStart(2, 3, solution);
            i3 = task2.Call(new int[] { 5, 5, 5, 5, 5 }, solution);
            PrintResult(i3, 5);

            // Test Case 4

            solution = 1;

            List<int> ints = new List<int>();
            for (int i = 0; i < 99; i++) { ints.Add(100); }
            for (int i = 0; i < 999900; i++) { ints.Add(i); }

            PrintStart(2, 4, solution);
            int i4 = task2.Call(ints.ToArray(), solution);
            PrintResult(i4, 100);

            solution = 2;

            PrintStart(2, 4, solution);
            i4 = task2.Call(ints.ToArray(), solution);
            PrintResult(i4, 100);

            solution = 3;

            PrintStart(2, 4, solution);
            i4 = task2.Call(ints.ToArray(), solution);
            PrintResult(i4, 100);


        }

        private static void RunTask3()
        {
            Task3 task = new Task3();
            int solution = 1;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            //PrintStart(3, 1, solution);
            //PrintResult(task.Call(new int[] { 4, 9, 8, 2, 6 }, 3, solution), 18);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 2;

            //PrintStart(3, 1, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 4, 9, 8, 2, 6 }, 3, solution), 18);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 1;

            //PrintStart(3, 2, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 2 }, 1, solution), 2);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 2;

            //PrintStart(3, 2, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 2 }, 1, solution), 2);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 1;

            //PrintStart(3, 3, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 7, 7, 7, 7, 7 }, 1, solution), -1);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 2;

            //PrintStart(3, 4, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 7, 7, 7, 7, 7 }, 1, solution), -1);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 1;

            //PrintStart(3, 5, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 2, 7, 7,7,6,6,6,6,1 }, 4, solution), 26);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 2;

            //PrintStart(3, 5, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 2, 7, 7, 7, 6, 6, 6, 6, 1 }, 4, solution), 26);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 1;

            //PrintStart(3, 6, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 2, 7, 7, 7, 4, 4, 4, 4, 6, 2, 1 }, 4, solution), 24);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 2;

            //PrintStart(3, 6, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 2, 7, 7, 7, 4, 4, 4, 4, 6, 2, 1 }, 4, solution), 24);
            //watch.Stop();
            //PrintTime(watch.Elapsed);


            //solution = 1;

            //PrintStart(3, 7, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 2, 8, 8, 8, 5, 5, 5, 5, 7, 2, 1 }, 4, solution), 28);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 2;

            //PrintStart(3, 7, solution);
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //PrintResult(task.Call(new int[] { 2, 8, 8, 8, 5, 5, 5, 5, 7, 2, 1 }, 4, solution), 28);
            //watch.Stop();
            //PrintTime(watch.Elapsed);

            //solution = 1;

            List<int> ints = new List<int>();
            for (int i = 0; i < 10000; i++) {

                for (int j = 1; j < 10; j++)
                {
                    ints.Add(j);
                } 
            }


            PrintStart(3, 8, solution);
            watch = System.Diagnostics.Stopwatch.StartNew();
            PrintResult(task.Call(ints.ToArray(), 4, solution), 36);
            watch.Stop();
            PrintTime(watch.Elapsed);

            solution = 2;

            PrintStart(3, 8, solution);
            watch = System.Diagnostics.Stopwatch.StartNew();
            PrintResult(task.Call(ints.ToArray(), 4, solution), 36);
            watch.Stop();
            PrintTime(watch.Elapsed);

            // Test Case 8

            ints = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {

                for (int j = 1; j < 9; j++)
                {
                    ints.Add(j);
                }
            }
            for (int i = 0; i < 30; i++)
            {
                ints.Add(9);
            }

            solution = 1;

            PrintStart(3, 8, solution);
            watch = System.Diagnostics.Stopwatch.StartNew();
            PrintResult(task.Call(ints.ToArray(), 32, solution), 286);
            watch.Stop();
            PrintTime(watch.Elapsed);

            solution = 2;

            PrintStart(3, 8, solution);
            watch = System.Diagnostics.Stopwatch.StartNew();
            PrintResult(task.Call(ints.ToArray(), 32, solution), 286);
            watch.Stop();
            PrintTime(watch.Elapsed);

            //List<int> ints = new List<int>();
            //for (int i = 0; i < length; i++)
            //{

            //}
        }

        public static int test3(int[]A, int K)
        {
            if(A.Length < K) { return -1; }
            Array.Sort(A);
            int[] startArray = A.Skip(Math.Max(0, A.Count() - K)).ToArray();
            if (startArray.Sum() % 2 == 0) { return startArray.Sum(); }
            foreach (int item in startArray)
            {
                for (int i = A.Length - (K + 1); i >= 0; i--)
                {
                    if (((startArray.Sum() - item) + A[i]) % 2 == 0)
                    {
                        return (startArray.Sum() - item) + A[i];
                    }
                }
            }
            return -1;
        }



        #region Print

        public static void PrintStart(int task, int testCase, int type)
        {
            Console.WriteLine("Task " + task + ", Test Case " + testCase + " Solution " + type);

        }
        public static void PrintTime(TimeSpan time)
        {
            Console.WriteLine("Time: " + time);
            Console.WriteLine("----------------------------");
        }
        public static void PrintResult(int result, int expected)
        {
            Console.Write("Result: " + result);
            Console.Write("   Passed: ");
            if(result == expected)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FALSE");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

        #endregion

    }

    enum TaskType
    {
        Task1,
        Task2,
        Task3
    }
}

