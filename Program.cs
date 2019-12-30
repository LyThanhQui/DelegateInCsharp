using System;

namespace DelegateInCsharp
{
    public class Program
    {
        // the first approach to call the methods of a class
        //NonStatic method
        public void Add(int x, int y)
        {
            Console.WriteLine(@"The Sum of {0} and {1}, is {2} ", x, y, (x + y));
        }
        //Static Method
        public static string Greetings(string name)
        {
            return "Hello @" + name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            //calling non static method through object
            obj.Add(100, 100);
            //Calling static method with class name
            string GreetingsMessage = Program.Greetings("Pranaya");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }
    }
}
