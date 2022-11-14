using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Strings & dates");


        Console.Write("Let us know your first name input: ");
        string firstName = Console.ReadLine();

        Console.Write("Let us know your last name input: ");
        string lastName = Console.ReadLine();

        Console.Write("Let us know your birth year input: ");
        int birthYear = int.Parse(Console.ReadLine());
        //use datetime in application
        var currentYear = DateTime.Now.Year;

        var yearDiff = currentYear - birthYear;
        string concatName = firstName + lastName;
        // practice using creating new modified strings

        Console.WriteLine($"Your name is : {firstName} {lastName} and you are {yearDiff} years old");

        // create program using split/join methods

        var yourData = new[] { firstName.ToString(), lastName.ToString(), birthYear.ToString(), yearDiff.ToString()  };
        Console.WriteLine(string.Join("*",yourData));

        


        int yourNumber = concatName.Length;
        Console.WriteLine($"Your name length is : { yourNumber} ");


    }
}

// create program using split/join methods

//USe timespan in application



// Use datetime offset in your application

//USe timezone in your application

// Use cultureinfo when working with strings and numbers

////Description: Mary and Luke are working everyday with XML documents that consist of multiple ‘app’ tags, both opening and 
//closing.A valid ‘app’ tag has the following format: < app ></ app >.Every once in a while the system that generates those files 
//produces invalid format: some opening, closing or both opening and closing ‘app’ tags might be missing. Luke creates a program 
//that reads the XML documents and provides all the ‘app’ tags in a sequence as a String. Now he needs help identifying how many 
//tags are out of order.
//Task: Create a Program – App Tag Interpreter, which when given a sample input string, consisting of opening and closing ‘app’ 
//tags, returns the number of tags, which are not in correct format (a closing tag that is missing opening tag, or opening tag that is 
//missing closing tag). 
//Examples:
//“< app >< app >< app ></ app ></ app >” -> 1 // only one ‘<app>’ tag is not closed.
//“< app ></ app ></ app >< app >< app >” -> 3 // one closing tag is not opened, two opening tags are not closed.
//“</ app >< app >< app ></ app ></ app >” -> 1 // one closing tag is not opened.//
//  //