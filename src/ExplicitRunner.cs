namespace InterfaceExercise;

class ExplicitRunner : IFirst, ISecond
{
    void IFirst.Run()
    {
        Console.WriteLine("I am first - void version");
    }

    int ISecond.Run()
    {
        Console.WriteLine("I am second - int version");
        return 42;
    }
}
