namespace N_Char;

class Program
{
    static void Main(string[] args)
    {
        char letter = Convert.ToChar(Console.ReadLine());
        
        //Convert from lower case to upper case
        if (letter >= 'a' && letter <= 'z') {
            int letterAfterConvertToInt = Convert.ToInt32(letter);
            letterAfterConvertToInt -= 32;
            letter = Convert.ToChar(letterAfterConvertToInt);
            Console.WriteLine(letter);
        }
        //Convert from upper case to lower case
        else if (letter >= 'A' && letter <= 'Z') {
            int letterAfterConvertToInt = Convert.ToInt32(letter);
            letterAfterConvertToInt += 32;
            letter = Convert.ToChar(letterAfterConvertToInt);
            Console.WriteLine(letter);
        }
    }
}