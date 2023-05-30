using System;
using System.Linq;

public static class Kata
{
    public static string Solution(string str)
    {
        var resultstring = new string(str.ToCharArray().Reverse().ToArray());
        Console.WriteLine(resultstring);
        return resultstring;
    }
}