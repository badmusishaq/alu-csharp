using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                if (ch != 'q' && ch != 'e')
                {
                    System.Console.Write((char)ch);
                }
            }
        }
    }
}