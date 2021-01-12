using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Give me a number please!");
		string input = Console.ReadLine();

		if (int.TryParse(input, out int num))
		{
			for (int i = 1; i < num + 1; i++)
			{
				if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("ping-pong");
				else if (i % 3 == 0) Console.WriteLine("ping");
				else if (i % 5 == 0) Console.WriteLine("pong");
				else Console.WriteLine(i);
			}
		}
		else
		{
			Console.WriteLine("That is not a number, I said number!!!!!!!!");
			Main();
		}
	}
}