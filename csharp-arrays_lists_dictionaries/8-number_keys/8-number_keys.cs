using System;
using System.Collections.Generic;

Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");

        Console.WriteLine("Number of keys: {0}", Dictionary.NumberOfKeys(myDict));
        
class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int number = 0;
        foreach (string key in myDict.Keys)
        {
            number++;
        }
        return number;
    }
}
