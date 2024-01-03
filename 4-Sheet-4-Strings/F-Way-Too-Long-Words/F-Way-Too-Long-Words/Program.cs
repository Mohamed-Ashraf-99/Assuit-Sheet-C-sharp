namespace F_Way_Too_Long_Words;

class Program
{
    static void Main(string[] args)
    {
        int numberOfTestCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < numberOfTestCases; i++) {
            string word = Console.ReadLine();
            int wordLength = word.Length;
            if (wordLength > 10)
                Console.WriteLine($"{word[0]}{wordLength - 2}{word[wordLength - 1]}");
            else
                Console.WriteLine(word);
        }
        
    }
}