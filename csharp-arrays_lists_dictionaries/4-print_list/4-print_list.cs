
List<int> newList;

        newList = List.CreatePrint(10);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(16);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(0);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(1);
        Console.WriteLine("List Length: " + newList.Count);       
        

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> myList = new List<int>();
        for (int i = 0; i < size; i++)
        {
            myList.Add(i);
            Console.Write(i + " ");
        }
        Console.WriteLine();

        return myList;
    }
}