namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generator g = new Generator();
            while (true)
                Console.WriteLine(g.Generate(200));
        }
    }
}