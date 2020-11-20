using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Complete the TODOs in the ListExercise.cs
            // Create List that contains 3 strings 
            // Call the static ProcessToKill method, pass in your list of strings
            var processes = new List<string>() { "RuntimeDll.exe", "Explorer.exe", "TaskManager.exe" };
            ListExercise.ProcessToKill(processes);

            Console.WriteLine();
            Console.WriteLine();

            // Complete the TODOs in the DictionaryExercise.cs
            // Create a List of type Employee
            var employees = new List<Employee>();
            // Populate the List
            employees.Add(new Employee("Shely Bricks", 25));
            employees.Add(new Employee("Manilla Gates", 25));
            employees.Add(new Employee("Jackson Stones", 26));
            employees.Add(new Employee("Jill Sterlings", 30));
            employees.Add(new Employee("Queen Stevens", 31));
            employees.Add(new Employee("Parker Houston", 31));
            // Call the static GetEmployeesByAge method and pass in your list
            var employeesDict = DictionaryExercise.GetEmployeesByAge(employees);

            foreach (var emp in employeesDict)
            {
                Console.Write($"{emp.Key} -> ");
                foreach (var item in emp.Value)
                {
                    Console.Write($"{item}  ");
                }
                Console.WriteLine();
            }



            // Complete the TODOs in the StackExercise method
            // Call the StackExercise method
            StackExercise();

            // Complete the TODOs in the QueueExercise method
            // Call the the QueueExercise method


        }

        public static void StackExercise()
        {
            // Create and initialize a new Stack object called myStack.
            //TODO Create a Stack collection of type string called myStack
            // Call the push method off of myStack and pass in "Hello,"
            // Call the push method off of myStack and pass in " World"
            // Call the push method off of myStack and pass in "!"
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            Console.WriteLine();

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
            //  Create new Queue of type string named myQ
            //  Call the Enqueue method off of myQ and pass in "Hello,"
            //  Call the Enqueue method off of myQ and pass in " World"
            //  Call the Enqueue method off of myQ and pass in "!"

            

            // Displays the properties and values of the Queue.
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            foreach (var item in myQ)
            {
                Console.Write("    {0}", item);
            }
        }
    }
}
