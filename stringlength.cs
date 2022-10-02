using System;

namespace datastructure
{
    class Stringlength
    {
        public static void stringlength()
        {
            char[] strdata = new char[8];
            string? inputdata = null;
            Console.WriteLine("Enter any string line: ");
            inputdata = Console.ReadLine();

            //strdata = inputdata.ToCharArray();

            int len = strdata.Length;   // Built-in function in C#
            Console.WriteLine("\nLength of the string \""+ inputdata + "\" is: " + len);

            
        
        }
    }
}