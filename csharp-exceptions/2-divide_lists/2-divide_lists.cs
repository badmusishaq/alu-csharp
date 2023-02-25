using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> finalList = new List<int>();
        int tempIndex = 0;
        for (int i = 0; i < listLength; i++)
        {
            try
            {
                tempIndex = list1[i] / list2[i];
                finalList.Add(tempIndex);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                finalList.Add(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Out of range");
            }
        }
        return finalList;
    }
}