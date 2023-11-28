using System;
using System.IO;

/// <summary>
///    Class to create an upper case copy of a file
/// </summary>
public class CopyFileUpper
{
	public static void Main()
	{
        try
        {
            Console.Write("Copy from: ");
            string sFrom = Console.ReadLine();
            Console.Write("Copy to: ");
            string sTo = Console.ReadLine();
            Console.Write($"Copy from: {sFrom} to: {sTo}");
            StreamReader srFrom = new StreamReader(sFrom);
            StreamWriter swTo = new StreamWriter(sTo);
            while (srFrom.Peek() != -1)
            {
                string sBuffer = srFrom.ReadLine();
                sBuffer = sBuffer.ToUpper();
                swTo.WriteLine(sBuffer);
            }
            swTo.Close();
            srFrom.Close();
        }
        catch (FileNotFoundException)
            {
                Console.WriteLine("Input file not found");
            }
        catch (Exception e) 
            {
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString());
            } 
	}       
}
