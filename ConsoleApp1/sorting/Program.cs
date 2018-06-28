using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class Program
    {

        static void Main(string[] args)
        {
            var fh = new FileHandler();
            var s = new DataParser();

            string path = "C:/Users/kyban/source/repos/sorting/unsorted_numbers(1).csv";

            int[] unsorted = fh.ReadFile(path);



            //foreach (var item in unsorted)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Starting Linear Search");
            var s1 = Stopwatch.StartNew();
            s.LinearSearchHighest(unsorted);
            s1.Stop();
            Console.WriteLine("Linear Search elapsed time: " + ((s1.Elapsed.TotalMilliseconds * 1000000).ToString("0.00 ns")));

            Console.WriteLine();

            var s3 = Stopwatch.StartNew();
            s.LinearSearchEvery1500th(unsorted);
            s3.Stop();
            Console.WriteLine("Elapsed Time: " + ((s3.Elapsed.TotalMilliseconds * 1000000).ToString("0.00 ns")));

            Console.WriteLine();
            Console.WriteLine();

            int[] sorted = s.ShellSort(unsorted);

            Console.WriteLine("Starting Binary Search");
            var s2 = Stopwatch.StartNew();
            Console.WriteLine("Using Binary Search - The Highest Number is " + sorted.Max());
            s2.Stop();
            Console.WriteLine("Binary Search elapsed time: " + ((s2.Elapsed.TotalMilliseconds * 1000000).ToString("0.00 ns")));

            Console.WriteLine();
            Console.WriteLine();

            var s4 = Stopwatch.StartNew();
            s.BinarySearchEvery1500th(sorted);
            s4.Stop();
            Console.WriteLine("Elapsed Time: " + ((s4.Elapsed.TotalMilliseconds * 1000000).ToString("0.00 ns")));

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
