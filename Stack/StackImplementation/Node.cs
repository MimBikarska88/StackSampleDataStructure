namespace StackImplementation;

public class Node <T>
{
    public T data { get; set; }
    public Node<T> prev { get; set; }

    public Node()
    {
        this.prev = null;
    }
}