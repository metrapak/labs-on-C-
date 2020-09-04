using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oop_lab2.text_elements
{
    public class Sentence
    {
        public string StrSentnce { get; set; }
        List<Word> words = new List<Word>();
        List<string> strWords = new List<string>();
        public char endOfSentence;
        public string buildedStrSentnce;
        public Sentence(string _sentnce)
        {
            StrSentnce = _sentnce;
            endOfSentence = StrSentnce[StrSentnce.Length - 1];
            strWords = SplitIntoWords(StrSentnce);
            for (int i = 0; i < strWords.Count; i++)
            {
                Word w = new Word(strWords.ElementAt(i));
                words.Add(w);
            }
            MyTask();
            buildSentence();

        }
        public List<string> SplitIntoWords(string text)
        {
            List<string> words = new List<string>();
            words = text.Split(new char[] { PMark.questionMark, PMark.exclamationPoint, PMark.dot, PMark.comma, PMark.whiteSpace }, StringSplitOptions.RemoveEmptyEntries).ToList();
            return words;
        }

        public void MyTask()
        {
            foreach (Word w in words)
            {
                string s = w.word.ToLower();
                var arr = s.ToCharArray();
                var result = "";
                foreach (char character in arr)
                {
                    if (character != arr[0])
                    {
                        result += character;
                    }
                }
                w.word = result;
            }
        }
        public string buildSentence()
        {
            
            buildedStrSentnce = string.Join(" ", words.Select(x => x.word).ToArray());
            buildedStrSentnce += endOfSentence;
            return buildedStrSentnce;
           }


    }
}
