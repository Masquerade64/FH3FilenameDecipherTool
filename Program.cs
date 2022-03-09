using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FH3FilenameDecipherTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Cipher = new char[38] { 'l', '`', '^', '6', 'q', 'v', '{', '@', '$', '7', 's', 'b', 'g', '8', 'h', 'u', 'f', '4', '~', '1', '=', '\'', 'm', ']', '!', ',', 'y', '_', '[', '0', 'w', 'k', '(', '2', 'j', '}', ';', '+'};
            char[] Clean  = new char[38] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '_', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

            string inputstring = args[0];
            string output = "";

            for (int i = 0; i < inputstring.Length; i++)
            {
                char c = inputstring[i];
                int cleanindex = Array.IndexOf(Cipher, c);
                output = output + Clean[cleanindex];
            }
            Console.WriteLine(output);
        }
    }
}
