using System.Text;

namespace StackImplementation;

public class Stack<T>
{
    public Node<T> Top{ get; set; }

    public Stack()
    {
        this.Top = null;
    }

    public void Push(T data)
    {
        var temp = new Node<T>();
        temp.data = data;
        temp.prev = Top;
        Top = temp;
    }

    public bool isEmpty() => Top == null;

    public T Peek()
    {
        if (isEmpty()) throw new InvalidOperationException("Stack is empty");
        return Top.data;
    }

    public T Pop()
    {
        if (isEmpty()) throw new InvalidOperationException("Stack is empty");
        T data = Top.data;
        Top = Top.prev;
        return data;
    }

    public override string ToString()
    {
        if (isEmpty()) return "...empty stack...";
        StringBuilder str = new StringBuilder();
        var temp = new Node<T>();
        temp = Top;
        while (temp!=null)
        {
            str.Append(temp.data + " ");
            temp = temp.prev;
        }

        return str.ToString();
    }
}