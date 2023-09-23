using System;

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
