using System;

static class Demo
{
    static Demo()
    {
        Console.WriteLine("Static Constructor");
    }

    public static void Show()
    {
        Console.WriteLine("Show");
    }
}

class Program
{
    static void Main()
    {
        Demo.Show();
        Demo.Show();
        Console.WriteLine("yash ");
    }
}