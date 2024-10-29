using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        String str;

        Console.Clear();
        str = Console.ReadLine();
        
        var convertStr = str.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
        string result = new String(convertStr.ToArray());
        
        Console.WriteLine(result);
    }
}
