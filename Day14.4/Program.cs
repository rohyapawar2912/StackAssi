namespace Pratice4
{
    public class Program
    {
        public static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine(queue.Dequeue()); // prints 56

            queue.DequeueFromBeginning();

            Console.WriteLine(queue.Dequeue()); // prints 70
            Console.WriteLine(queue.Dequeue()); // throws InvalidOperationException
        }
    }
}