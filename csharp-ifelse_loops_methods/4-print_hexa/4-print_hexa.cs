// See https://aka.ms/new-console-template for more information

for(int n = 0; n <= 98; n++)
{
    string hex = n.ToString("x");
    Console.Write(n + " = 0x" + hex);
}