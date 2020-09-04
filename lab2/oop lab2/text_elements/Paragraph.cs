using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oop_lab2.text_elements
{
    public class Paragraph
    {
        public string StrParagraph { get; set; }
        List<Sentence> sentences = new List<Sentence>();
        List<string> strSentences = new List<string>();
        public string buildedStrParagraph;
        public Paragraph(string _paragraph)
        {
            StrParagraph = _paragraph;
            SplitIntoSentences(StrParagraph);
            for (int i = 0; i < strSentences.Count; i++)
            {
                Sentence s = new Sentence(strSentences.ElementAt(i));
                sentences.Add(s);
            }
            buildParagraph();
        }
        public void SplitIntoSentences(string text)
        {

            strSentences = Regex.Split(text, @"(?<=[\.!\?])\s+").ToList();
            if (strSentences[strSentences.Count - 1] == "") strSentences.RemoveAt(strSentences.Count - 1);
        }

        public void buildParagraph()
        {

            buildedStrParagraph = string.Join(" ", sentences.Select(x => x.buildedStrSentnce).ToArray());
            
        }
    }
}
