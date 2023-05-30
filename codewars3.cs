using System;

public class Accumul
{
    public static String Accum(string s)
    {
        //turn the string into an array so we can look at each letter.
        char[] charArr = s.ToCharArray();
        //initialise and new string to add to and to return.
        string newArray = "";
        int counter = 0;
        string dash = "";

        foreach (char ch in charArr)
        {
            newArray += dash;
            //add the uppercase version of each item of the array of characters to the string we want to return
            newArray += char.ToUpper(ch);

            int internalCounter = 1;
            while (internalCounter <= counter)
            {
                newArray += char.ToLower(ch);
                internalCounter++;
            }
            dash = "-";
            counter++;
        }
        return newArray;
    }
}