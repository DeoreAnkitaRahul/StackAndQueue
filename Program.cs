﻿namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program");
            Console.WriteLine("Create queue using Linked List");

            QueueUsingLinkedList queue = new QueueUsingLinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

            Console.WriteLine("Dequeue");

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();


        }

    }
    }
