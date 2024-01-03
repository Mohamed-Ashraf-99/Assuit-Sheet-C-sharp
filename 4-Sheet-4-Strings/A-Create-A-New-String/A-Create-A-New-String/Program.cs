namespace A_Create_A_New_String;

class Program
{
    static void Main(string[] args)
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();
        Console.WriteLine($"{firstString.Length} {secondString.Length}");
        string concatStrings = firstString + " " + secondString;
        Console.WriteLine(concatStrings);
    }
}