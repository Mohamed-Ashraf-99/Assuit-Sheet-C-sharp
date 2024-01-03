using System.Text;

namespace D_Strings;

class Program
{
    static void Main(string[] args)
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();
        
        Console.WriteLine($"{firstString.Length} {secondString.Length}");
        Console.WriteLine($"{firstString}{secondString}");
        
        char firstCharOfFirstString = firstString[0];
        char firstCharOfSecondString = secondString[0];

        string firstStringAfterReplacemnet = firstCharOfSecondString + firstString.Substring(1);
        string secondStringAfterReplacemnet = firstCharOfFirstString + secondString.Substring(1);
        Console.WriteLine($"{firstStringAfterReplacemnet} {secondStringAfterReplacemnet}");
    }
}