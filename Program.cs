namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program");
            Console.WriteLine("Create Stack using Linked List");

            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.Push(50);
            stack.Push(20);
            stack.Push(80);
            stack.Display();
        }
    }
}