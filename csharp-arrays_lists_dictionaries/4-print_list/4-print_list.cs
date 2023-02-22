// See https://aka.ms/new-console-template for more information
//List<int> newList;

//newList = new List<int>();

//int addedNumber = 0;

//addedNumber++;
CreatePrint(10);

void CreatePrint(int size)
{
    int[] numbersToPrint;

    numbersToPrint.Length = size;

    if(size < 0)
    {
        Console.WriteLine("Size cannot be negative");
        return;
    }
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine(numbersToPrint[i]);
    }    
}

Console.WriteLine("List Length: " + CreatePrint(10));
