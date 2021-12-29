using System;
using System.IO;

public class Example
{
    public static void Main()
    {
        string fileName = @"D:\prog\networklog.txt";

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            
            string newLine = "";
            string newLine1 = "";
            string[] result;
            while ((line = reader.ReadLine()) != null)
            {
                result = line.Split(':');
                if (line != "")
                {
                    
                   newLine = newLine + '\t' + result[0];
                   newLine1 = newLine1 + '\t' + result[1];
                    //Console.WriteLine(result[0]);
                }
            }

            Console.WriteLine(newLine);
            Console.WriteLine(newLine1);
        }
    }
}