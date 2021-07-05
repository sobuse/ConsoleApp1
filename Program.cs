using System;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;
               
                Console.WriteLine("@Echo: " + input);
            }
        }
    }
}