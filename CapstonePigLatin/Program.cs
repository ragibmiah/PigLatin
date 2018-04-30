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
            //Using the regular expression to omit numbers but it cant't get numbers within words.
            Regex specialCharacter = new Regex("^[0-9]*$");
            //This is to check my vowels.
            string vowels = "aeiouAEIOU";

            Console.Write("\nEnter a word to be translated: ");
            string input = Console.ReadLine().ToLower();
            //Using to lower the letters for less error.

            string[] stringArray = input.Split(' ');
            //My attempt to break into sentences. did not work like i planned.


            //For every time a person puts nothing in, they get asked to try again.
            if (input == "")
            {
                Translate();
            }
            else if (specialCharacter.IsMatch(input))
            {
                Console.WriteLine(input);
                //This finds numbers but not within words.
            }
            else if (input.Substring(0, 1) == "a" || input.Substring(0, 1) == "e" || input.Substring(0, 1) == "i" || input.Substring(0, 1) == "o" || input.Substring(0, 1) == "u" || input.Substring(0, 1) == "A" || input.Substring(0, 1) == "E" || input.Substring(0, 1) == "I" || input.Substring(0, 1) == "O" || input.Substring(0, 1) == "U")
            {
                Console.WriteLine(input + "way");
                //Used the long way to check for vowels in the beginning of words.
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
                           //This is used to check for vowels after consonants.
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
