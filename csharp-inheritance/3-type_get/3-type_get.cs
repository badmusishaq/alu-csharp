using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="derivedType">Object from where to get informations.</param>
    /// <param name="baseType">Object type</param>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
