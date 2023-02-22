// See https://aka.ms/new-console-template for more information
int[] newArray;

newArray = Array.CreatePrint(0);
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
            return null;
        }

        int[] newSize = new int[size];

        for(int i = 0; i < size; i++)
        {
            Console.WriteLine("{0} ", i);
            // if(size == 0)
            // {
            //     Console.WriteLine("\t");
            // }
            // else if(size < 0)
            // {
            //     Console.WriteLine("Size cannot be negative");
            //     //return null;
            // }
            // else if(size > 0)
            // {
            //     Console.WriteLine("{0} ", i);
            // }
        }
        return newSize;
    }
}