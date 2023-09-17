// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

int[] newArray;

newArray = Array.CreatePrint(10);
Console.WriteLine("Array Length: " + newArray.Length);
Console.WriteLine("----------------");

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] tab = new int[size];
        var output = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            output.Append(i);
            if (i != size - 1)
            {
                output.Append(" ");
            }
            tab[i] = i;
        }

        Console.WriteLine(output);

        return tab;
    }
}