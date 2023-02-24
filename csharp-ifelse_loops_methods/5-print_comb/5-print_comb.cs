// See https://aka.ms/new-console-template for more information
Console.Write("00");
for(int i = 1; i <= 99; i++)
{
    string separator = ", ";

    if (i == 99)
    {
        separator = "\n";
    } 
    Console.Write("{0}", i.ToString("00") + separator);
}
