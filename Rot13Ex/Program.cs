using System.Text;

internal class Program
{
    /*ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. 
     * ROT13 is an example of the Caesar cipher.

    Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string,
    they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
    */
    private const string PLAIN = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    private const string CIPHER = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
    private static void Main(string[] args)
    {
        Console.WriteLine(Rot13("C# is cool!"));
        Console.WriteLine(Rot13("Test"));
        Console.WriteLine(Rot13("Test"));
    }
    public static string Rot13(string message)
    {
        if (string.IsNullOrEmpty(message)) return "";

        var sb = new StringBuilder();


        for (int i = 0; i < message.Length; i++)
        {
            if (char.IsLetter(message[i]))
            {
                sb.Append(CIPHER[PLAIN.IndexOf(message[i])]);
            }
            else
            {
                sb.Append(message[i]);
            }
        }
        return sb.ToString();
    }

    public static string Rot13Linq(string message)
    {
        if (string.IsNullOrEmpty(message)) return "";

        return string.Concat(message.Select((x, i) => char.IsLetter(message[i]) ? CIPHER[PLAIN.IndexOf(message[i])] : x));
    }
}