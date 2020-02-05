using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class ListExercise
    {
        public static List<string> ProcessToKill(List<string> process)
        {
            // Create list of string with initial size to 3.
            var processToKill = new List<string>(3);

            // Show capacity ; here : 3.
            Console.WriteLine(processToKill.Capacity);

            // Show number of items ; here : 0.
            Console.WriteLine(processToKill.Count);

            /// TODO: 
            /// Add items from process to processToKill list
            foreach (var item in process)
            {
                processToKill.Add(item);
            }
            
            foreach (var p in processToKill)
            {
                Console.WriteLine(p);
            }

            return processToKill;
        }
    }
}
