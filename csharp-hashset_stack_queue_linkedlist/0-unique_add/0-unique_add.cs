using System;
using System.Collections.Generic;

    class List
    {
    public static int Sum(List<int> myList)
        {
        List<int> uniquIntegers = new List<int>();
        int sum = 0;
        foreach (var elem in myList)
        {
            if (!uniquIntegers.Contains(elem))
            {
                uniquIntegers.Add(elem);
                sum += elem;
            }
        }
        return sum;
        }
    }