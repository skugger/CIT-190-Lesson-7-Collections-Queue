using System;
using System.Collections;
using System.Collections.Generic;

namespace CIT_190_Lesson_7_Collections_Queue
{
    class Program
    {
        public static void Main()
        {

            Queue bookTitles = new Queue();

            bookTitles.Enqueue("The Positronic Man");
            bookTitles.Enqueue("The Caves of Steel");
            bookTitles.Enqueue("The Naked Sun");
            bookTitles.Enqueue("The Robots of Dawn");
            bookTitles.Enqueue("Pebble in the Sky");

            foreach (var b in bookTitles)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine();
            Console.WriteLine("These are " + bookTitles.Count + " books by Isaac Asimov.");

            Console.WriteLine();
            Console.WriteLine("Is one of them named 'Pebble in the Sky'? " + bookTitles.Contains("Pebble in the Sky") + "!");
            Console.WriteLine();

            Console.WriteLine("Removing the first from the list...");
            bookTitles.Dequeue();
            Console.WriteLine("now there's " + bookTitles.Count + " left:");
            Console.WriteLine();

            foreach (var b in bookTitles)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();


        }
    }
}