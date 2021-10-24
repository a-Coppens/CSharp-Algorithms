using System;

namespace CSharp_Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StringReverser alphabetReverse = new StringReverser("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            Console.WriteLine(alphabetReverse.reversed);
        }
    }
}
