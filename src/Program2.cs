namespace InterfaceExercise;

public class Program2 : IStart, IReset
{
    public void Start()
    {
        Console.WriteLine("Nu kör vi program 2");
    }

    public void Reset()
    {
        Console.WriteLine("Reset");
    }
}

interface IReset
{
    public void Reset();
}
