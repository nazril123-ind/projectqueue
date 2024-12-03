using System;
using System.Collections;


namespace Queueproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue first = new Queue();
            first.Enqueue(60);
            first.Enqueue(45);
            first.Enqueue(11);
            first.Enqueue(7);

            Queue second = new Queue();
            second.Enqueue(67);
            second.Enqueue(65);
            second.Enqueue(32);
            second.Enqueue(12);

            ProcessInOrder(first, second);

            Console.WriteLine(
                "press any key to continue...");
            Console.ReadKey();
        }
        static void ProcessInOrder(Queue first, Queue second)
        {
            while (first.Count > 0 || second.Count > 0)
            {

                if (first.Count == 0)
                {
                    Console.WriteLine(second.Dequeue());
                    continue;
                }
                if (second.Count == 0)
                {
                    Console.WriteLine(first.Dequeue());
                    continue;
                }

                if ((int)first.Peek() >= (int)second.Peek())
                {
                    Console.WriteLine(
                        second.Dequeue());
                }
                else
                {
                    Console.WriteLine(first.Dequeue());
                }
            }
        }
    }
}
