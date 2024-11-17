//Повернута ли строка?
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine(IsStringRotated("javascript", "scriptjava")); // true
        Console.WriteLine(IsStringRotated("javascript", "iptjavascr")); // true
        Console.WriteLine(IsStringRotated("javascript", "java"));       // false
    }

    static bool IsStringRotated(string source, string test)
    {
        if (source.Length != test.Length)
        {
            return false;
        }

        string doubledSource = source + source;

        return doubledSource.Contains(test);
    }
}
