using System;
using System.Collections.Generic;

    class List
    {
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> finalList = new List<int>();

        foreach (var elem in list1)
        {
            if (list2.Contains(elem))
            {
                finalList.Add(elem);
            }
        }
        return finalList;
    }
}