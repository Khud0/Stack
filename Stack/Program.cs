using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push("Doodad");
            stack.Push(new Point());
            stack.PrintStatus();

            Console.WriteLine($"Popped object: {stack.Pop()}"); 
            Console.WriteLine($"Popped object: {stack.Pop()}");         
            stack.PrintStatus();
            
            stack.Clear();
            stack.PrintStatus();
        }
    }
}
