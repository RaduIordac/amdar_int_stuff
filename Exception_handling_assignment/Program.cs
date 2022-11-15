// See https://aka.ms/new-console-template for more information

// Create methods which checks input arguments and throw exceptions

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Try ... ");
        var currentDate = DateTime.Now;
        

        try
        {
            Console.Write("Let us know your name input: ");
            string yourName = Console.ReadLine();

            Console.Write("Let us know your birth year ");
            int birthYear = int.Parse(Console.ReadLine());
        }

        catch (Exception) 
            { if (birthYear <= currentDate.Year)
            {
                Console.WriteLine($"You are not {currentDate.Year - birthYear} old");
                }
            
            else ((currentDate.Year - birthYear) < 18) {
            throw new Exception($"You are not old enough to continue"); } 
            }

        finally { Console.WriteLine($"Congratulations {yourName} you can do it!"); }
    }
}

//create custom exceptions and throw them

// write try- catch-finally block with multiple catch statements

//retrow exception

//add conditionalcompilatiom symbols

// Use  debug class to write debug information to output window

