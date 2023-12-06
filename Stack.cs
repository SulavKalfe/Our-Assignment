class Stack<T>{
    private readonly List<T> items;

    public Stack(){
        items = new List<T>();
    }

    public void Push(T item){
        items.Add(item);
    }

    public T Pop(){
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T poppedItem = items[^1];
        items.RemoveAt(items.Count - 1);
        return poppedItem;
    }

    public T Peek(){
        if (items.Count == 0){
            throw new InvalidOperationException("Stack is empty");
        }

        return items[^1];
    }

    public bool IsEmpty(){
        return items.Count == 0;
    }
}

//class Program{
//    static void Main(){
//        Stack<int> intStack = new();

//        intStack.Push(3);
//        intStack.Push(6);
//        intStack.Push(9);
//        int poppedItem = intStack.Pop();
//        Console.WriteLine($"Popped item: {poppedItem}");
//        intStack.Push(12);

//        int topItem = intStack.Peek();
//        Console.WriteLine($"Top item: {topItem}");

//        bool isEmpty = intStack.IsEmpty();
//        Console.WriteLine($"Is the stack empty? {isEmpty}");
//    }
//}