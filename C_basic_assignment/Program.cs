// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Classes");

// Create a program which uses classes to model real world objects


public abstract class Building
{
    protected Building()
    {
    }

    public virtual void constructBuilding(int floorsNR)
    {
        Console.WriteLine($"Building will have {floorsNR} levels");
    }
}

public class OneFloorHouse : Building
{
    int HouseNr;
    string street;

    public int HouseNr { get; set; }


    public override void constructBuilding(int floorsNR = 1 )
    {
        Console.WriteLine($"This house has one floor ");
    }
    public static hasWindows(int windowNr, string windowType)
        {
        Console.WriteLine($"This house has {windowNr} windows of {windowType} ");
    }
    
}
// use methods and fields to encapsulate class implementation

//use properties to make some properties accesible or replace trivial methods (getters/setters)

//Create a class hiereechy to model real world Hierachies (animal in zoo, shapes in drawing system)

//Create a method and make its overloaded and overrriden verions

//Implement . NET IEnumerable interface

// Implement  .NET Icloneable interface
