namespace MadLibs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome to Mad Libs App! *****");
            
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What is your age?");
            string? age = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What is the name of your city?");
            string? city = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What is the name of your country?");
            string? country = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What is your profession?");
            string? profession = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What type of animal do you have?"); 
            string? animal = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("What is your pet's name?");
            string? petName = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("*********************************");
            Console.WriteLine($"There was a person named {name} who lived in {city}. " +
                $"At the age of {age}, {name} decided to move to {country} and become a {profession}." +
                $"Then, {name} adopted a(n) {animal} named {petName}. They both lived happily ever after!");

            Console.WriteLine("***** END Mad Libs App! *****");
            Console.ReadKey();

        }
    }
}
