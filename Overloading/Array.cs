using System;

class ReturnArray
{
	public static void Main(String[] args)
	{
	char[] characters = ArrayReturn();
	Console.WriteLine("Elements in array : ");
	for(int i=0;i<characters.Length;i++)
	{
		Console.WriteLine(characters[i]);
	
	}		
	}

	public static char[] ArrayReturn()
	{
	
	char[] charArray = new char[]{'A','B','C','D'};

	return charArray;


	}
}