namespace StackCollection;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();

        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);
        myStack.Push(50);

        int specificItem = 30;
        bool containsItem = myStack.Contains(specificItem);
        Console.WriteLine($"Does the stack contain {specificItem}? {containsItem}");

        int removedItem = myStack.Pop();
        Console.WriteLine($"Removed item from the stack: {removedItem}");

        int itemCount = myStack.Count;
        Console.WriteLine($"Number of items in the stack: {itemCount}");

        Console.WriteLine("Items in the stack:");
        foreach (var item in myStack)
        {
            Console.WriteLine(item);
        }
    }
}

