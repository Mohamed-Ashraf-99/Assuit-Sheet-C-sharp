namespace M_Capital_or_Small_or_Digit;
//Given a letter X. Determine whether X is Digit or Alphabet and if it is Alphabet determine if it is Capital Case or Small Case.
class Program
{
    static void Main(string[] args)
    {
        char letter = Convert.ToChar(Console.ReadLine());
        //Check is the letter is upper case
        if (letter >= 'A' && letter <= 'Z') {
            Console.WriteLine("ALPHA");
            Console.WriteLine("IS CAPITAL");   
        }
        //Check is the letter is lower case
        else if (letter >= 'a' && letter <= 'z') {
            Console.WriteLine("ALPHA");
            Console.WriteLine("IS SMALL");   
        }
        //Check is digit
        else
            Console.WriteLine("IS DIGIT");
    }
}