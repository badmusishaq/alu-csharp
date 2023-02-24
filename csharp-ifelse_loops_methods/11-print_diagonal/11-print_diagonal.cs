Line.PrintDiagonal(15);
class Line
{
	public static void PrintDiagonal(int length)
	{
		if (length <= 0)
		{
			Console.WriteLine();
		}
        else
        {
			for (int i = 0; i < length; i++)
			{
				// Print spaces before the line
				for (int j = 0; j < i; j++)
				{
					Console.Write(" ");
				}
				
				// Print the line
				Console.WriteLine("\\");
			}
        }
	}
}
