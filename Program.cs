namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program");
            Console.WriteLine("Create queue using Linked List");

            QueueUsingLinkedList queue = new QueueUsingLinkedList();
            queue.Enqueue(50);
            queue.Enqueue(80);
            queue.Enqueue(60);
            queue.Display();
        }
    }
    }
}