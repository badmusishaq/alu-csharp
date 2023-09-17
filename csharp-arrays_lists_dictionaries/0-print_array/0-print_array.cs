// See https://aka.ms/new-console-template for more information
int[] newArray;

newArray = Array.CreatePrint(10);
Console.WriteLine("Array Length: " + newArray.Length);
Console.WriteLine("----------------");

class Array
{
    public static int[] CreatePrint(int size)
    {
        if(size == 0)
        {
            Console.WriteLine("\t");
        }
        else if(size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return new int[0];
        }

        int[] newSize = new int[size];

        for(int i = 0; i < size; i++)
        {
            Console.WriteLine("{0} ", i);
        }
        return newSize;
    }
}