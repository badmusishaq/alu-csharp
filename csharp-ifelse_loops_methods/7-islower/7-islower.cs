using System;

char c = 'A';
bool isLower = Character.IsLower(c);
Console.WriteLine(isLower);

class Character
{
	public static bool IsLower(char c)
	{
		int letterValue = (int)c;
		if (letterValue >= 97 && letterValue <= 122)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
