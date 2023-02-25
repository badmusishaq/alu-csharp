using System;
using System.Collections.Generic;

List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
        List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
        List<int> different;

        different = List.DifferentElements(myList1, myList2);

        foreach (int i in different)
            Console.WriteLine(i);
            
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2){
        List<int> uniqueList = new List<int>();
        foreach (var elem in list1)
            {
            if (!list2.Contains(elem))
            {
                uniqueList.Add(elem);
            }
        }
        foreach (var elem in list2)
        {
            if (!list1.Contains(elem))
            {
                uniqueList.Add(elem);
            }
        }
        uniqueList.Sort();
        return uniqueList;
    }
}