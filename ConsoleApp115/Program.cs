//Плосткий массив
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var nestedArray = new object[] { new object[] { 1 }, new object[] { 2, 3 }, new object[] { new object[] { 4 } } };
        var flattenedArray = Flatten(nestedArray);

        Console.WriteLine(string.Join(", ", flattenedArray)); 
    }

    static List<int> Flatten(object[] array)
    {
        var result = new List<int>();
        foreach (var element in array)
        {
            if (element is object[] nestedArray)
            {
                result.AddRange(Flatten(nestedArray)); 
            }
            else if (element is int number)
            {
                result.Add(number); 
            }
        }
        return result;
    }
}
