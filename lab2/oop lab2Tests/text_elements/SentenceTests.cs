using Microsoft.VisualStudio.TestTools.UnitTesting;
using oop_lab2.text_elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab2.text_elements.Tests
{
    [TestClass()]
    public class SentenceTests
    {
        [TestMethod()]
        public void MyTaskTest()
        {
            FullText fullText = new FullText("Hello! Hello!");
            string expectedValue = "ello! ello!";
            Assert.AreEqual(expectedValue, fullText.buildedStrFullText);
        }

        [TestMethod()]
        public void SplitIntoWordsTest()
        {
            Sentence fullText = new Sentence("Hello, my name is Artem!");
            List<string> expectedResult = new List<string>();
            expectedResult.Add("Hello");
            expectedResult.Add("my");
            expectedResult.Add("name");
            expectedResult.Add("is");
            expectedResult.Add("Artem");
            

            List<string> realResult = new List<string>();
            realResult = fullText.SplitIntoWords("Hello, my name is Artem!");

            for (int i = 0; i < realResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], realResult[i]);
            }
        }

        [TestMethod()]
        public void buildSentenceTest()
        {
            Sentence fullText = new Sentence("Hello, my name is Artem!");
            string expected = "ello y ame s rtem!";
            Assert.AreEqual(expected, fullText.buildSentence());

        }
    }
}