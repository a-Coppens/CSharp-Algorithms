using System;

namespace C__Algo_s
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
