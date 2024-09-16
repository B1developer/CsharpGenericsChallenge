// Generic Stack class
public class Stack<T>
{
    // Internal list to hold the elements
    private List<T> _stack = new List<T>();

    // Method to push an element onto the stack
    public void Push(T item)
    {
        _stack.Add(item);
        Console.WriteLine($"Pushed: {item}");
    }

    // Method to pop an element off the stack
    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        T item = _stack[_stack.Count - 1];  // Get the last item
        _stack.RemoveAt(_stack.Count - 1);  // Remove the last item
        Console.WriteLine($"Popped: {item}");
        return item;
    }

    // Method to check if the stack is empty
    public bool IsEmpty()
    {
        return _stack.Count == 0;
    }

    // Bonus: Method to peek at the top element without removing it
    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        return _stack[_stack.Count - 1];
    }

    // Bonus: Method to clear the stack
    public void Clear()
    {
        _stack.Clear();
        Console.WriteLine("Stack cleared.");
    }
}

// Main program to test the generic stack
class Program
{
    static void Main(string[] args)
    {
        // Create a stack of integers
        Stack<int> intStack = new Stack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);

        Console.WriteLine($"Top element: {intStack.Peek()}");  // Should print 30
        intStack.Pop();  // Removes 30
        intStack.Pop();  // Removes 20
        intStack.Clear();  // Clears the stack

        // Create a stack of strings
        Stack<string> stringStack = new Stack<string>();
        stringStack.Push("Hello");
        stringStack.Push("World");
        Console.WriteLine($"Top element: {stringStack.Peek()}");  // Should print "World"
        stringStack.Pop();  // Removes "World"
        stringStack.Pop();  // Removes "Hello"

        // Trying to pop from an empty stack will throw an exception
        try
        {
            stringStack.Pop();
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);  // Output: "The stack is empty."
        }
    }
}
