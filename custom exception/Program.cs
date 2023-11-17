
using System;

public class AgeException : Exception
{
    public AgeException(String message)
        : base(message)
    {

    }
}
public class TestUserDefinedException
{
    static void validate(int age)
    {
        if (age < 18)
        {
            throw new AgeException("Sorry, Age must be greater than 18");
        }
    }
    public static void Main(string[] args)
    {
        try
        {
            validate(13);
        }
        catch (AgeException e)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine("Rest of the code");
        Console.ReadLine();

    }
}

