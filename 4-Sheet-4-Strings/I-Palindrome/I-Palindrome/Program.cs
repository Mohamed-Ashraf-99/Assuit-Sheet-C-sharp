namespace I_Palindrome;

class Program
{
    static void Main(string[] args)
    {
        string originalString = Console.ReadLine();
        char[] stringArray = originalString.ToCharArray();
        
        Array.Reverse(stringArray);
        string reversedString = new string(stringArray);

        if (originalString == reversedString)
            Console.WriteLine("YES");
        else 
            Console.WriteLine("NO");
    }
}