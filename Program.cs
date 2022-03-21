using System;

class Program
{
    public static void Main(string[] args)
    {
        Foo f = new Foo();
        f.OnKeyPressed += (_, c) => Console.WriteLine(c);
        f.Run();
    }
}

public class Foo
{
    public event EventHandler<char> OnKeyPressed;

    public void Run()
    {
        char input = Console.ReadKey().KeyChar;
        while (input != 'c')
        {
            OnKeyPressed?.Invoke(this, input);
            input = Console.ReadKey().KeyChar;
        }
    }
}