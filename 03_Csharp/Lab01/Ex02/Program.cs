namespace Ex02_Greetings
{
    internal class Greeter
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.Write($"Hello, {myName}");
        }
    }
}
