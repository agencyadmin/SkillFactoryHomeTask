using System;

class MainClass
{
	public static void Main(string[] args)
	{

		string MyName;
		byte MyAge;
		enum DayOfWeek : byte
		{Sunday, Monday, Tuesday, Wednessday, Thirsday, Friday, Surturday 
		}
		
		Console.WriteLine("What is your name?");
		MyName = Console.ReadLine();
		Console.WriteLine("What is your age?");
		MyAge = (byte)Console.ReadLine();
		Console.WriteLine("Your name is {0} and your age is {1}", MyName, MyAge);
		DayOfWeek Day = (DayOfWeek)int.Parse(Console.ReadLine());
		Console.WriteLine($"Enter your favorite day of week:{Day}");
		
		
}
