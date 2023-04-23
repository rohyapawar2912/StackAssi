namespace Practice2
{
    public class Program
    {
        public static void Main()
        {
            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}