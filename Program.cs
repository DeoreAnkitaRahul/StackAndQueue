﻿namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program");
            Console.WriteLine("Create Stack using Linked List");

            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }

    }
    }
