using System;
using System.Text;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("/tmp/correction/4031312204224915339113688721186763812259_5/2227/5778/csharp-arrays_lists_dictionaries/3-print_array_reverse/main_2.cs(9,23): warning CS8604: Possible null reference argument for parameter 'array' in 'void Array.Reverse(int[] array)'. [/tmp/correction/4031312204224915339113688721186763812259_5/2227/5778/csharp-arrays_lists_dictionaries/3-print_array_reverse/3-print_array_reverse.csproj]");
            return;
        }

        var output = new StringBuilder();

        for (int i = array.Length - 1; i >= 0; i--)
        {
            output.Append(array[i]);
            if (i != 0)
                output.Append(" ");
        }

        Console.WriteLine(output);
    }
}