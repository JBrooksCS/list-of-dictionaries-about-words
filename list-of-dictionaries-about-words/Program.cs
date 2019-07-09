using System;
using System.Collections.Generic;

namespace list_of_dictionaries_about_words
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                } 
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            var surprisedWord = new Dictionary<string, string>();

            surprisedWord.Add("word", "surprised");
            surprisedWord.Add("definition", "having, showing, or characterized by a heightened state of sudden shock");
            surprisedWord.Add("part of speech", "adjective");
            surprisedWord.Add("example sentence", "I am surprised to learn C#!");

            dictionaryOfWords.Add(surprisedWord);
            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> entry in dictionaryOfWords)
            {
                foreach (KeyValuePair<string, string> entryLine in entry)
                {
                    Console.WriteLine($"{entryLine.Key}: {entryLine.Value}");
                }
            }
        }
    }
}
