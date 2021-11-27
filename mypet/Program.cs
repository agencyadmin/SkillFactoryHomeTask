using System;

class MainClass
{
	public static void Main(string[] args)
	{

		string MyName;
		byte MyAge;
		bool HaveIApet = true;
		double MyShoeSize = 37.5;
		enum DayofWeek : byte
		{Sunday, Monday, Tuesday, Wednessday, Thirsday, Friday, Surturday 
		}
		
		Console.WriteLine("What is your name?");
		MyName = Console.ReadLine();
		Console.WriteLine("What is your age?");
		MyAge = (byte)Console.ReadLine();
		Console.WriteLine("Your name is {0} and your age is {1}", MyName, MyAge);
		DayofWeek Day = (DayofWeek)int.Parse(Console.ReadLine());
		Console.WriteLine($"Enter your favorite day of week:{Day}");
		
		}
}
