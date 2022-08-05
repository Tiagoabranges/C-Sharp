public class Program
{
    public static void Main()
    {        
        string someString = "2022";
        Console.WriteLine(someString is string);

        int convertInt = Convert.ToInt32(someString);
        Console.WriteLine(convertInt is int);
    }            
}