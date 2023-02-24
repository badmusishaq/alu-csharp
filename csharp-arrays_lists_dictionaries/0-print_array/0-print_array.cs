using System.Text;
int[] newArray;

newArray = Array.CreatePrint(0);
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

        int[] newSize = new int[size];

        var printString = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            printString.Append(i);
            if (i != size - 1)
            {
                printString.Append(" ");
            }
            newSize[i] = i;
        }

        Console.WriteLine(printString);
        return newSize;
    }
}