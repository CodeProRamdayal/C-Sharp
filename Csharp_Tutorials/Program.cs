// QuizApp
using Csharp_Tutorials.Arrays;
using Csharp_Tutorials.Methods;
using Csharp_Tutorials.OopsConcepts;
using Csharp_Tutorials.QuizApp;
//string question1 = "What is the capital of France?";
//string answer1 = "Paris";
//string question2 = "What is 2 + 2?";
//string answer2 = "4";
//string question3 = "What is the largest planet in our solar system?";
//string answer3 = "Jupiter";

//string question4 = "What color is the sky on a clear day?";
//string answer4 = "blue";

//int score = 0;

//int num1 = 0;
//Console.WriteLine(question1);
//string userAnswer1 = Console.ReadLine();
//bool isValidInput = int.TryParse(userAnswer1, out num1);
//if (isValidInput)
//{
//    Console.WriteLine("Well done, You entered a number");
//}
//else
//{
//    Console.WriteLine("Invalid input. Please enter a number.");

//}


//if(userAnswer1 == answer1)
//{
//    Console.WriteLine("Correct !");
//    score = score + 1;
//}
//else
//{
//    Console.WriteLine("Wrong answer. The correct answer is: " + answer1);
//}

//
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter the first number :");

//int firstNumber = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the second number :");
//int secondNumber = int.Parse(Console.ReadLine());
//int result = firstNumber + secondNumber;
//Console.WriteLine("The result is: " + result);

//Console.ReadKey();

/*
 using System;
using System.Xml.Linq;

namespace OppConcept
{

    class Program
    { 
        static void Main(string[] args)
        {
            // Create a new instance of the Person class
            //Persons person = new Persons();
            //person.Name = "John";
            //person.DisplayName("Alice");

            //// Create a new instance of the Person class using the static Parse method
            //var p = Persons.Parse("John");
            //p.DisplayName("Alice");

            // Create a new instance of the Customer class using the default constructor
            //Customer customer =  new Customer();
            //Customer cusomter1 = new Customer("John");
            //cusomter1.Orders.Add(new Order());
            //cusomter1.Orders.Add(new Order());
            //Console.WriteLine("Order count {0}:" , cusomter1.Orders.Count);
            //cusomter1.DisplayCustomerInfo();
            //Customer customer2 = new Customer("John", 'M', 30);
            //customer2.DisplayCustomerInfo();

            // Ref / out Modifier

            int a = 1;
            //MethodOverloading.Add(a);
            //Console.WriteLine("A value without Ref :: " + a);
            // wth ref modifier
            MethodOverloading.Add(a);
            // Concatenation
            Console.WriteLine("A value with Ref :: " + a);

            // String Interpolation
            Console.WriteLine($"A value with Ref :: {a}");

            ChallengeClubbing.ISAllowedClubbing();
        }
    }
}
 */

/*
 using Loops;
using System;


//WhileLoop.GuessNumeber();

//AdventureGame.StartGame();
//LoopBasic.BasicLoop();

// ArrayBasic.BasicArray();
//ArrayBasic.BasicArray();
//TwoDimensionalArray.BasicTwoDimensionalArray();

//Exercise 001

int[] numbers = { 1, 2, 3, 4, 5 };
foreach(int number in numbers)
{
    Console.WriteLine("Number value : {0}", number);
}
 */

//InBuildMethods.GenerateRandomNumber();

var inAndOutRef = new Csharp_Tutorials.Variables.InAndOutREF();
//var detail = new Csharp_Tutorials.Variables.MyDetail { Id = 1, Name = "Alice" };
//inAndOutRef.RefByValue(ref detail);
//int sum, product;
//inAndOutRef.OutByValue(10, 2, out sum, out product);
//Console.WriteLine($"Sum: {sum}, Product: {product}");

// Arrays 
//var OneDArray = new SingleDArray();
//int[] arr;
//OneDArray.UserInputArray(out arr);
//foreach(int ele in arr)
//{
//Console.WriteLine("User Inputed Array elemnet {0}",ele);
//}

// Find Max element in an array
//int[] arr = {1,2,3,4,10,5, 6, 7, 8, 9 };
//Methods methods = new Methods();
//int maxElement  = methods.FindMax(arr, out maxElement);
//Console.WriteLine("Find the max element: {0}", maxElement);

//int factorialOf5 = methods.Factorial(15);
//Console.WriteLine("Factorial of 5: {0}", factorialOf5);

// Weather Station Simulator
//WeatherStationSimulator weatherStation = new WeatherStationSimulator();

//weatherStation.WaatherCondition();

// Day 9
// Oops Concepts

//Car audi = new Car("Audi Serices" ,"AI19","AUDI");
//Car bmw = new Car("BMW serices", "i7", "BMW");
//audi.Model = "I912";

//Console.WriteLine("Audi" , audi.Model) ;
//Console.WriteLine("Audi" + audi.Model);
//    audi.Age = 10;
// audi.BuyCar = true;
//if (audi.Age < 18)
//{
//    Console.WriteLine("My son you are not eliagiable for drive the car : " + (audi.BuyCar.Equals(false)? "NO":""));
//}
//else
//{
//    Console.WriteLine("Yes, You are eligiable to drive car." + (audi.BuyCar.Equals(true) ? "Yes":""));
//}


//// Ref vs out
//var carName = "Audi with gold color";
//var carAmount = 2000;

//var bikeName = "Davison 200";
//var bikeAmount = 1400;
//Console.WriteLine("Car Deatils before the Method calling"+ carName  + " "+carAmount);

// Car.MyCarDetail(out carName, out carAmount);
//Console.WriteLine("Car Deatils after the Method calling"+carName + " " +carAmount);

//Console.WriteLine("Bike Deatils before the Method calling" + bikeName + " " + bikeAmount);

//Car.MyBikeDetail(ref bikeName, ref bikeAmount);
//Console.WriteLine("Bike Deatils after the Method calling" + bikeName + " " + bikeAmount);


// Constructorsn
//Constructors_day11 cust = new Constructors_day11("");
//Console.WriteLine(cust.Name);
//cust.Name = "\"Akanksha Singh Patel\"";
//Console.WriteLine(cust.Name);

// Static Keyword

//StaticKeyword staticKeyword = new StaticKeyword();
StaticKeyWords staticKey = new StaticKeyWords();
staticKey.Width = 10;
staticKey.Height = 5;

Console.WriteLine("Area of the rectangle: " + staticKey.Area);
Console.WriteLine("Height of the rectangle: " + staticKey.Height);
Console.WriteLine("Width of the rectangle: " + staticKey.Width);

int result = Convert.ToInt32(staticKey.Area.ToString());
Console.WriteLine("Double value: " + StaticKeyWords.DoubleValue(result));
// Operator overloading
StaticKeyWords staticKey2 = new StaticKeyWords
{
    Width = 15,
    Height = 10
};
//staticKey2.Width = 15;
//staticKey2.Height = 10;
StaticKeyWords sum = staticKey + staticKey2;
Console.WriteLine("Sum of rectangles - Width: " + sum.Width + ", Height: " + sum.Height);

StaticKeyWords staticKey3 = new StaticKeyWords();

staticKey3.Width = 2;
staticKey3.Height = 3;

StaticKeyWords product = staticKey * staticKey2 * staticKey3;
Console.WriteLine("Product of rectangles - Width: " + product.Width + ", Height: " + product.Height);

Console.WriteLine("Instance count: " + StaticKeyWords.CountInstances);

//Console.WriteLine("Sum of Rectangles: " + StaticClassCalcluator.Add(10, 5));
Console.WriteLine("Subtraction of Rectangles: " + StaticClassCalcluator.Subtract(10, 5));
Console.WriteLine("Multiplication of Rectangles: " + StaticClassCalcluator.Muliply(10, 5));
Console.WriteLine("Division of Rectangles: " + StaticClassCalcluator.Divide(10, 5));



IsandAsKeyword.CheckedValue();