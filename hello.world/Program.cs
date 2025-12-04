namespace hello.world
{
    public class GreetingGenerator
    {
        public string GenerateGreeting()
        {
            return "Hello, World!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var generator = new GreetingGenerator();
            // This now just runs the function
            Console.WriteLine(generator.GenerateGreeting());
        }
    }
}