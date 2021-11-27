using System;

class Program
{
    public static void Main(string[] args)
    {

        string name;
        string age;
        string pet;
        string footsize;

        Console.WriteLine("Как вас зовут?");
        name = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        age = Console.ReadLine();
        Console.WriteLine("Если ли у вас питомец?");
        pet = Console.ReadLine();
        Console.WriteLine("Какой у вас размер ноги?");
        footsize = Console.ReadLine();

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(pet);
        Console.WriteLine(footsize);
        Console.ReadKey();
    }
}