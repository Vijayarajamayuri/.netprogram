using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
  
                // Specify the data source.
                int[] scores = new int[] { 97, -8, 81, 60 };

                // Define the query expression.
                IEnumerable<int> scoreQuery =
                    from score in scores
                    where score > -7
                    select score;

                // Execute the query.
                foreach (int i in scoreQuery)
                {
                    Console.Write(i + " ");
                }
            }
        }
        // Output: 97 92 81
    }


