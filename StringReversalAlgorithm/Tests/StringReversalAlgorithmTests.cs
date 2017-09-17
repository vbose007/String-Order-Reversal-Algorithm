using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using StringReversalAlgorithm;

namespace Tests
{
    public class StringReversalAlgorithmTests
    {
        private IStringReverseAlgorithm _algorithm;

        [SetUp]
        public void Setup()
        {
            _algorithm = new StringReverseAlgorithm();
        }

        [TestCase("This is a test")]
        [TestCase("Can you reverse this?")]
        [TestCase("Well if you can, then prove it!")]
        public void AlgorithmCanReverseOrderOfWordsInGivenString(string str)
        {
            var words = str.Split(' ');

            var lastWord = words[words.Length - 1];
            var firstWord = words[0];

            var reversedString = _algorithm.ReverseString(str);

            Assert.IsTrue(reversedString.StartsWith(lastWord));
            
            Assert.IsTrue(reversedString.EndsWith(firstWord));
        }

    }
}
