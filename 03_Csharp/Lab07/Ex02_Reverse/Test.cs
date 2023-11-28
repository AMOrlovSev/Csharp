namespace Ex02_Reverse
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to reverse:");
            string test = Console.ReadLine();
            Utils.Utils.Reverse(ref test);
            Console.WriteLine(test);
        }
    }
}
