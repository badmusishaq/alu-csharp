// See https://aka.ms/new-console-template for more information
/*int[] newArray;

newArray = Array.CreatePrint(10);
Console.WriteLine("Array Length: " + newArray.Length);
Console.WriteLine("----------------");*/

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
            return new int[0]; // Return an empty array
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] newArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
            Console.Write($"{i} ");
        }

        Console.WriteLine(); // Move to the next line after printing the elements

        return newArray;
    }
}