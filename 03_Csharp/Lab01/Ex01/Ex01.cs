using System;

class Program
{
	static void Main()
	{
		string myName;
		Console.WriteLine("Please enter your name");
		myName = Console.ReadLine();
		Console.Write($"Hello, {myName}");
		Console.ReadKey();
	}
}