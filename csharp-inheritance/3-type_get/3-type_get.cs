using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">Object from where to get informations.</param>
    public static void Print(object myObj)
    {
        Type objectType = myObj.GetType();

        Console.WriteLine($"{objectType.Name} Properties:");
        Console.WriteLine($"{objectType.Name} Methods:");

        // Print methods
        MethodInfo[] methods = objectType.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
