﻿int[] array = {10, 17, -8, 4, -12, 7, 0, 1, -1, -9};

        Console.WriteLine("Element at index {0} is {1}", 4, Array.elementAt(array, 4));
        Console.WriteLine("Element at index {0} is {1}", 9, Array.elementAt(array, 9));
        Console.WriteLine("Element at index {0} is {1}", 0, Array.elementAt(array, 0));
        Array.elementAt(array, -7);
class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index < 0 || index > array.Length - 1)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        return array[index];
    }
}
