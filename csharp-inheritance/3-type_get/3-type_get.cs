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
        Type type = myObj.GetType();

        Console.WriteLine("{0} Properties:", type.Name);
        foreach (PropertyInfo info in type.GetProperties())
        {
            Console.WriteLine(info.Name);
        }

        Console.WriteLine("{0} Methods:", type.Name);
        foreach (MethodInfo info in type.GetMethods())
        {
            Console.WriteLine(info.Name);
        }
    }
}
