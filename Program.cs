internal class Program
{
    private static void Main(string[] args)
    {
        A anyName = new A(5);
        anyName.getDoubleNumberofWheels();
        Console.WriteLine(A.someNumber);

        A anyValue = new A(6);
        anyValue.getDoubleNumberofWheels();
        Console.WriteLine(A.someNumber);

        anyName.getDoubleNumberofWheels();
        Console.WriteLine(A.someNumber);

    }
}