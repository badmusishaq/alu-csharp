using System;
using System.Text;

class Array
{
    public static void Reverse(int[] array)
    {
        var output = new StringBuilder();
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array == null)
            {
                Console.WriteLine(array[i]);
                return;
            }
            output.Append(array[i]);
            if (i != 0)
                output.Append(" ");
        }
        Console.WriteLine(output);
    }
}