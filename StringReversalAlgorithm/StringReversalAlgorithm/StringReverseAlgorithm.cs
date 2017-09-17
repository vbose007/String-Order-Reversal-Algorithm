using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversalAlgorithm
{
    public class StringReverseAlgorithm : IStringReverseAlgorithm
    {

        public string ReverseString(string @string)
        {
            var words = SplitIntoListOfWords(@string);

            var reversedWords = ReverseOrderOfWords(words);

            var reversedString = JoinWordsIntoSpaceSeparatedString(reversedWords);

            return reversedString;
        }

        private static string JoinWordsIntoSpaceSeparatedString(IEnumerable<string> reversedWords)
        {
            return string.Join(" ", reversedWords);
        }

        public  IEnumerable<string> ReverseOrderOfWords(string[] words)
        {
            var reversedString = words.Reverse();
            return reversedString;
        }

        public string[] SplitIntoListOfWords(string @string)
        {
            var words = @string.Split(' ');
            return words;
        }
    }
}
