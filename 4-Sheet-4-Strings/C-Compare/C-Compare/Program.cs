namespace C_Compare;

class Program
{
    static void Main(string[] args)
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();
        if(firstString.CompareTo(secondString) >= 0)
            Console.WriteLine(secondString);
        else
            Console.WriteLine(firstString);
    }
}