using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */

            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Armadillo", "a nocturnal omnivorous mammal that has large claws for digging and a body covered in bony plates. Armadillos are native to the south central US and Central and South America.");
            wordsAndDefinitions.Add("Definition", "the act of defining, or of making something definite, distinct, or clear");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["Awesome"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            /////////////////////////////////////////////////////////////////////////////////////////////

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            dictionaryOfWords.Add(excitedWord);

            Dictionary<string, string> sadWord = new Dictionary<string, string>();

            sadWord.Add("word", "sad");
            sadWord.Add("definition", "Feelin sorrowful yo");
            sadWord.Add("part of speech", "adjective");
            sadWord.Add("example sentence", "I am sad af.");

            dictionaryOfWords.Add(sadWord);

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> dictionary in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> word in dictionary)
                {
                    Console.WriteLine($"{word.Key}: {word.Value}");
                }
            }

        }
    }
}
