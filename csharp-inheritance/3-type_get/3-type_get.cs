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
        foreach (PropertyInfo prop in objectType.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"\n{objectType.Name} Methods:");
        foreach (MethodInfo method in objectType.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
