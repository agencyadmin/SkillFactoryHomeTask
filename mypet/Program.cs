using System;

class MainClass
{
	public static void Main(string[] args)
	{
		string MyName;
		byte MyAge;
		enum DayOfWeek
	{ 
	Sunday = 7,
	Monday = 1, 
	Thuesday = 2, 
	Wednesday = 3, 
	Thursday = 4,
	Friday = 5, 
	Saturday =6
	}
	Console.WriteLine("What is your name?");
		MyName = Console.ReadLine();
		Console.WriteLine("What is your age?");
		MyAge = (byte) int.parse(Console.ReadLine());
	Console.WriteLine("Your name is {0} and your age is {1}", MyName, MyAge);
		DayOfWeek Day = DayOfWeek.((DayOfWeek)int.Parse(Console.ReadLine()));
	Console.WriteLine($"Enter your favorite day of week:{Day}");
	}	
}
 