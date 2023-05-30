using System;
using System.Linq;

public class Digits
{
    public static string Explode(string s)
    {
        char[] charArr = s.ToCharArray();
        string newArray = "";

        foreach (char ch in charArr)
        {
            int charValue = int.Parse(ch.ToString());

            for (int i = 0; i < charValue; i++)
            {
                newArray += ch;

            }
        }
        return newArray;

    }
}
