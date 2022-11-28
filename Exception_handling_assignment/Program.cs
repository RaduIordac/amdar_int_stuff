// Create methods which checks input arguments and throw exceptions

using System.Diagnostics.CodeAnalysis;

internal class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Try ... ");
        var currentDate = DateTime.Now;
        

        Console.Write("Let us know your name input: ");
        try
        {
            string yourName = Console.ReadLine();
        }
        catch (ArgumentNullException)
        {

            throw new ArgumentNullException("Name must be not be empty: ");
        }

        Console.Write($"Let us know your birth year between 0 and {currentDate.Year}:");


        int birthYear = int.Parse(Console.ReadLine());

        
        {

            try
            {
                if (birthYear == 0) { 
                throw new Exception($"You are not {currentDate.Year - birthYear} old");
                }
                else if (birthYear.ToString().Length > 4)
                {
                    throw new ArgumentOutOfRangeException("Year format must be 4 digits");
                }
                else if (currentDate.Year - birthYear < 18)
                {
                    throw new Exception($"You are not old enough to continue");
                }
            }

            catch (FormatException e) 
            {
                throw new FormatException("Not a valid year input",e);        
                    }

            catch (ArgumentOutOfRangeException ex) 
            {
                throw new ArgumentOutOfRangeException($"Year must be between 0 and {currentDate.Year}", ex);
            }


            finally
            {
                //Console.WriteLine($"Congratulations {yourName} you are {currentDate.Year - birthYear} years old , you can do it!");

                Console.WriteLine($"Congratulations  you are {currentDate.Year - birthYear} years old , you can do it!");
            }
        }   
    }
}


//create custom exceptions and throw them

// write try- catch-finally block with multiple catch statements

//retrow exception

//add conditionalcompilatiom symbols

// Use  debug class to write debug information to output window

