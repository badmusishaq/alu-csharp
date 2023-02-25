using System;
using System.Text;

int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null;
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        Array.Reverse(array1);
        Array.Reverse(array2);
        Array.Reverse(array3);
        Array.Reverse(array4);
    class Array
    {
    public static void Reverse(int[] array)
    {
        var output = new StringBuilder();
        if (array != null)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}