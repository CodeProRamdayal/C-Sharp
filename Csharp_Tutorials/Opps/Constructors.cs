using Csharp_Tutorials.Opps;
using System;

public class Customer
{
	private string Name;
	private int Age;
	private char Gender;
    /*
	 Construector overloading is a technique in object-oriented programming that allows a class to have multiple constructors with different parameter lists. This allows for the creation of objects with different initializations based on the provided arguments. In C#, constructor overloading is achieved by defining multiple constructors within a class, each with a unique signature (i.e., different number or types of parameters). When an object is instantiated, the appropriate constructor is called based on the arguments passed during object creation.
	 Constructor overloading is possinble with Same class name but different parameter list. The compiler determines which constructor to call based on the number and types of arguments provided during object creation.
	 Constructor chaning is a technique in object-oriented programming where one constructor calls another constructor within the same class. This is often done to avoid code duplication and to provide a more streamlined way of initializing objects. In C#, constructor chaining is achieved using the "this" keyword followed by the appropriate constructor's parameter list. When an object is instantiated, the constructors are called in a chain, starting from the most specific constructor and moving up to the more general ones.
     */
    // default constructor
	public readonly List<Order> Orders = new List<Order>();
    public Customer()
	{
        Orders = new List<Order>();	
        Console.WriteLine("This is the default constructor for Customer.");
	}

	public Customer(string name) : this()
	{
		this.Name = name;
	}
	public Customer(string name ,char gender, int age) : this(name)
	{
		this.Age = age;
		this.Gender = gender;
	}

    public void DisplayCustomerInfo()
    {
        Console.WriteLine("Customer Name: " + this.Name);
        Console.WriteLine("Customer Age: " + this.Age);
        Console.WriteLine("Customer Gender: " + this.Gender);
    }
}
