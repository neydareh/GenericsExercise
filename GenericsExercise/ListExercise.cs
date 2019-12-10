using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class ListExercise
    {
        public static List<string> ProcessToKill(List<string> process)
        {
            // Create list of string with initial size to 3.
          
            // Show capacity ; here : 3.

            // Show number of items ; here : 0.

            /// TODO: 
            /// Add items from process to processToKill list 
            /// Process equals "Explorer.exe" don't be added, ignore it


            foreach (var p in processToKill)
            {
                Console.WriteLine(p);
            }

            return processToKill;
        }
    }
}
