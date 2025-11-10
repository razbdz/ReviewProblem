using System;

namespace SentenceFromWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words of a sentence one by one including punctuation:");

            string sentence = "";
            string word = "";

            while (true)
            {
                word = Console.ReadLine();
                sentence += word + " ";

                // Stop if the word ends with '.', '!' or '?'
                if (word.EndsWith(".") || word.EndsWith("!") || word.EndsWith("?"))
                {
                    break;
                }
            }

            Console.WriteLine(sentence.Trim());
        }
    }
}

