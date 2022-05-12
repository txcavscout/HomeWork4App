string firstName;

do
{
    Console.Write("Enter your name. Type exit to stop: ");
    firstName = Console.ReadLine();
    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome Professor {firstName}");
    }
    else if (firstName.ToLower() == "exit")
    {
        Console.WriteLine("...closing");
    }
    else
    {
        Console.WriteLine($"Welcome student {firstName}");
    }
} while (firstName != "exit");

Console.WriteLine("\nGoodbye.");


