using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab2.text_elements
{
    public class FullText
    {
        public string fText;
        public List<string> strParagraphs  = new List<string>();
        public List<Paragraph> paragraphs = new List<Paragraph>();
        public string buildedStrFullText;
        public FullText(string _text)
        {
            fText = _text;
            SplitIntoParagraphs(fText);
            for (int i = 0; i < strParagraphs.Count; i++)
            {
                Paragraph p = new Paragraph(strParagraphs.ElementAt(i));
                paragraphs.Add(p);
            }
            buildText();
        }
        public void SplitIntoParagraphs(string text)
        {
            strParagraphs = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public void buildText()
        {

            buildedStrFullText = string.Join("\n", paragraphs.Select(x => x.buildedStrParagraph).ToArray());
        }

    }
}
