namespace Parse;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Int.Parse Example
        Console.WriteLine("enter integer number for Int.Parse:");
        string input = Console.ReadLine();
        int parsedInt = int.Parse(input);
        Console.WriteLine($"Int.Parse output: {parsedInt}");
       

        // Int.TryParse Example
        Console.WriteLine("Int.TryParse example: enter integer number");
        input = Console.ReadLine();
        if (int.TryParse(input, out int tryParsedInt))
        {
            Console.WriteLine($"Int.TryParse output: {tryParsedInt}");
        }
        else
        {
            Console.WriteLine("Int.TryParse failed");
        }

        // Double.Parse Example
        Console.WriteLine("Enter a double :");
        input = Console.ReadLine();

        double parsedDouble = double.Parse(input);
        Console.WriteLine($"Double.Parse output: {parsedDouble}");

        // Double.TryParse Example
        Console.WriteLine("Enter a double (Double.TryParse):");
        input = Console.ReadLine();
        if (double.TryParse(input, out double tryParsedDouble))
        {
            Console.WriteLine($"Double.TryParse output: {tryParsedDouble}");
        }
        else
        {
            Console.WriteLine("Double.TryParse failed.");
        }
    }
}

/*
სხვაობა:
1. Parse: ტექსტური ტიპი გადაყავს რიცხვობრივ ტიპში.
2. TryParse: აბრუნებს boolean-ს

მსგავსება:ორივე მეთოდი ცდილობს ტექსტური ტიპის გადაყვანას ციფრულ ტიპში.
*/
