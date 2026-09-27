namespace Csharp_Tutorials.Oops
{

    public class Animal
    {
        public void Eat()
            {
           
                Console.WriteLine("All Animals  are Eating");
            }

    }
    internal class InhieritanceClass : Animal
    {
            public static void  Main(string[] args)
            {
                InhieritanceClass obj = new InhieritanceClass();
                obj.Eat();
            }
    }
}
