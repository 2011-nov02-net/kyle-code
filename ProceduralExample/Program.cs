using System;

namespace ProceduralExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");
            Console.WriteLine("Enter multiple words: ");
            string input = Console.ReadLine();
            string [] output = input.Split(' ');
            foreach(string s in output){
                Console.Write(s[0]);
            }
            Console.WriteLine();
        }
    }
}
