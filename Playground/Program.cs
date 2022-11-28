// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        
            IMessageWriter writer = new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Exclaim();
        
    }
}

public class Salutation
{
    private readonly IMessageWriter writer;
    public Salutation(IMessageWriter writer)
    {
        if (writer == null) { throw new ArgumentNullException("writer"); }
        this.writer = writer;

        
    }
    public void Exclaim()
    {
        this.writer.Write("Hello DI from Exclaim");
    }
}

public interface IMessageWriter
{
    void Write(string message);
}

public class ConsoleMessageWriter : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine(message, "From ConsoleMessage");
    }
}