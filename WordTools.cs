using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFun
{
    internal class WordTools
    {
        public int WordCounter(string words)
        {
            //variables
            int wordCount = 0;

            //split the string into seperate words to make it easier to count
            string[] individualWords = words.Split(" ");

            wordCount = individualWords.Length;

            return (wordCount);
        }

        public int CharacterCounter(string words)
        {
            int characterCount = 0;

            characterCount = words.Length;

            return (characterCount);
        }

        public void AlphabetCounter(string words)
        { 
            int[] letters = new int[26]; //holds the count of each letter (a-z)

            //Loop throught the entire string
            for(int i = 0; i < words.Length; i++)
            {
               

                char c = words[i];

                c = Char.ToLower(c);

                if (c >= 97 && c <= 122) //check to make sure it is a lower case letter
                {
                    letters[(c - 97)]++;
                }
            }

            //Print Results from the array
            for(int i = 0; i < letters.Length; i++)
            {
                char letter = (char)(i + 97);

                Console.WriteLine(letter + ": " + letters[i]);
            }
        }
    }
}
