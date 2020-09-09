using System;

namespace ArrayAndForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new []{3,7,9,2,14,6};

            Console.WriteLine("Length  "+numbers.Length);

            foreach(int x in numbers)
            {
               Console.WriteLine(x);
            }
        }
    }
}
