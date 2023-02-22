// See https://aka.ms/new-console-template for more information

for(int n = 0; n <= 98; n++)
{
    //int decValue = int.Parse(n.ToString("X"), System.Globalization.NumberStyles.HexNumber);
    //Console.Write(n + " = " + Convert.ToInt32(n.ToString(), 16)+"\t");
    //Console.Write(n + " = " + decValue + "\t");
    Console.Write(n + " = " + string.Format("{0:X}", n) + "\t");
}
//Console.WriteLine("Hello, World!");
