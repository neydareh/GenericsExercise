using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class ListExercise
    {
        public static List<string> ProcessToKill(List<string> process)
        {
            // Create list of string with initial size to 3.
            List<string> processToKill = new List<string>(3);

            // Show capacity ; here : 3.
            Console.WriteLine($"Capacity of the stack: {processToKill.Capacity}");

            // Show number of items ; here : 0.
            Console.WriteLine($"Number of processes: {processToKill.Count}");

            /// TODO: 
            /// Add items from process to processToKill list 
            /// Process equals "Explorer.exe" don't be added, ignore it
            ///
            foreach (var task in process)
            {
                if(task != "Explorer.exe")
                    processToKill.Add(task);
            }

            foreach (var p in processToKill)
            {
                Console.WriteLine(p);
            }

            return processToKill;
        }
    }
}
