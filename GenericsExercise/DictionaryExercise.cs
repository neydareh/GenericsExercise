using System;
using System.Collections.Generic;

namespace GenericsExercise
{
    public class DictionaryExercise
    {
        public static Dictionary<int, List<string>> GetEmployeesByAge(List<Employee> employees)
        {
            var result = new Dictionary<int, List<string>>();

            foreach (var e in employees)
            {
                //TODO: add employees to result, 
                //      the key must contain age and 
                //      values are names list who have the same age.
                var names = new List<string>();
                if (result.ContainsKey(e.Age))
                {
                    names.Add(e.Name);
                    result[e.Age].AddRange(names);
                }
                else
                {
                    names.Add(e.Name);
                    result.Add(e.Age, names);
                }
            }
            return result;
        }
    }
}
