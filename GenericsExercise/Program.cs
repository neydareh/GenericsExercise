using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Complete the TODOs in the ListExercise.cs
            // Create List of 3 strings 
            // Call the static ProcessToKill method, pass in your list of strings
            var strings = new List<string>
            { "some string", "something", "games"};
            ListExercise.ProcessToKill(strings);

            // Complete the TODOs in the DictionaryExercise.cs
            // Create a List of type string
            // Call the static GetEmployeesByAge method
            var employees = new List<Employee>();
            DictionaryExercise.GetEmployeesByAge(employees);

            // Complete the TODOs in the StackExercise method
            // Call the StackExercise method
            StackExercise();

            // Complete the TODOs in the QueueExercise method
            // Call the the QueueExercise method
            QueueExercise();

        }

        public static void StackExercise()
        {
            // Create and initialize a new Stack object called myStack.
            //TODO Create a Stack collection of type string called myStack
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");


            // Displays the properties and values of the Stack.
            //**Uncomment the lines below**

            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (var item in myStack)
            {
                Console.Write("    {0}", item);
            }
        }

        public static void QueueExercise()
        {
            // Create and initialize a new Queue object called myQ.
            Queue<string> myQ = new Queue<string>();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            // Displays the properties and values of the Queue.
            //**Uncomment the lines below**

            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            foreach (var item in myQ)
            {
                Console.Write("    {0}", item);
            }
        }
    }
}
