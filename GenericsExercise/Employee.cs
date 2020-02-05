using System;
namespace GenericsExercise
{
    public class Employee : IEquatable<Employee>
    {
        public int Age;
        public string Name;


        public Employee(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public bool Equals(Employee other)
        {
            return (Age == other.Age && Name == other.Name);
        }
    }
}
