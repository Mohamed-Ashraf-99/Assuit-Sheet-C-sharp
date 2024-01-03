using System.Text;

namespace G_Conversion;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string origin = input.Replace(',', ' ');
        StringBuilder afterSwitch = new StringBuilder();
        foreach (char ch in origin)
        {
            if (char.IsUpper(ch))
                afterSwitch.Append(char.ToLower(ch));
            else if (char.IsLower(ch))
                afterSwitch.Append(char.ToUpper(ch));
            else if (char.IsWhiteSpace(ch))
                afterSwitch.Append(' ');
        }
        Console.WriteLine(afterSwitch);
    }
}