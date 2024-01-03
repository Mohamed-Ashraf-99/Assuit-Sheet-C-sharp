namespace B_Lets_use_Getline;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] afterSplit = input.Split(@"\");
        string stringAfterSign = afterSplit[0];
        Console.WriteLine(stringAfterSign);
    }
}