using System;
using System.Text.RegularExpressions;


namespace CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Translate();
        }
    static void Translate()
        {

            Regex specialCharacter = new Regex("^[0-9]*$");
            string vowels = "aeiouAEIOU";

            Console.Write("\nEnter a word to be translated: ");
            string input = Console.ReadLine().ToLower();

            if (input == "")
            {
                Translate();
            }
            else if (specialCharacter.IsMatch(input))
            {
                Console.WriteLine(input);
            }
            else if (input.Substring(0, 1) == "a" || input.Substring(0, 1) == "e" || input.Substring(0, 1) == "i" || input.Substring(0, 1) == "o" || input.Substring(0, 1) == "u" || input.Substring(0, 1) == "A" || input.Substring(0, 1) == "E" || input.Substring(0, 1) == "I" || input.Substring(0, 1) == "O" || input.Substring(0, 1) == "U")
            {
                Console.WriteLine(input + "way");
            }
            else
            {
                string data = input;

                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (input[i] == vowels[j])
                        {
                            string pigLatin = input.Substring(i, (input.Length - i));
                            string firstLetter = data.Substring(0, i);
                            Console.WriteLine(pigLatin + firstLetter + "ay");
                            j = vowels.Length;
                            i = input.Length;
                           
                        }

                    }

                }

            }
            Console.WriteLine("\nTranslate another word? (Y or N)");
            string output = Console.ReadLine().ToLower();

            if (output == "y")
            {
                Translate();
            }
            else if (output == "n")
            {
                return;
            }
        }
    }
}
