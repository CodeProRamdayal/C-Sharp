    using Csharp_Tutorials.Opps;


namespace Csharp_Tutorials.Opps
{
public class Persons
{
    public string Name;
    public void DisplayName(string to)
    {
        Console.WriteLine("Hi {0} Welcome back in Opp world!. i am {1}", to, Name);
    }
    //  use static keyword to make the method static
    public static Persons Parse(string str)
    {
        var person = new Persons();
        person.Name = str;
        return person;
    }
}
}