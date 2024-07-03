// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace DI.Understanding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.ServeMethod();
            Console.ReadKey();
        }
    }
}