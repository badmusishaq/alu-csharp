using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("The array is null.");
            return;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}
}