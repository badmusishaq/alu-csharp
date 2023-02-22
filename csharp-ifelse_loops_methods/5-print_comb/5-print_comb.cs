// See https://aka.ms/new-console-template for more information
Console.Write("00");
for(int i = 1; i <= 99; i++)
{
    Console.Write(", {0}", i.ToString("00"));
}
Console.WriteLine();
