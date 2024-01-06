namespace J_Count_Letters;

class Program
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int[] letterCount = new int[26];

        foreach (char ch in word)
        {
            if (char.IsLower(ch))
            {
                int index = ch - 'a';
                letterCount[index]++;
            }
        }

        for (int i = 0 ; i < 26 ; i++)
        {
            if (letterCount[i] > 0)
            {
                char letter = (char)('a' + i);
                Console.WriteLine($"{letter} : {letterCount[i]}");
            }
        }
    }
}