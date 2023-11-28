namespace Ex04_InterfaceTest
{
    internal class test
    {
        static void Main(string[] args)
        {
            int intTest = int.MaxValue;
            ulong ulongTest = ulong.MaxValue;
            string stringTest = "stringTest";

            Console.WriteLine($"int: {Utils.Utils.IsItFormattable(intTest)}");
            Console.WriteLine($"ulong: {Utils.Utils.IsItFormattable(ulongTest)}");
            Console.WriteLine($"string: {Utils.Utils.IsItFormattable(stringTest)}");
        }
    }
}
