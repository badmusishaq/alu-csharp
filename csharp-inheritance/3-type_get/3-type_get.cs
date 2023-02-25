using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    public static void Print(object myObj){
        string cType = myObj.GetType().Name;
        Type t = myObj.GetType();
        Console.WriteLine("{0} Properties:", cType);
        foreach (var p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", cType);
        foreach (var m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}
