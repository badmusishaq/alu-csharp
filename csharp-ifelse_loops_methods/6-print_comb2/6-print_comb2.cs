using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i ++)
                for (int j = 0; j < 10; j++)
                {
                    if (j > i)
                    {
                        if (i < 8 || j < 9)
                        {
                            Console.Write(i+""+j + ", ");
                        }
                        else
                        {
                            Console.Write(i+""+j);
                        }
                    }                      
                }
            Console.WriteLine();
        }
    
    }
}
