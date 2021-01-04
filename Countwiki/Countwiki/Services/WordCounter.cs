using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countwiki.Services
{
    public class WordCounter : IWordCounter
    {
        public WordCounter()
        {

        }

        public int CountDistinct(string html)
        {
            List<string> allWords = new List<string>();
            int distinctWordCount = 0;
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // work with the body and ignore the rest
            var body = htmlDocument.DocumentNode.SelectSingleNode("//body");
            if(body == null) { return 0; } // no body element found

            // selecting just text nodes you may get javascript in ther as well.
            // so "//text()[not(parent::script)]" eliminates the javscript from the count
            var textNodes = body.SelectNodes("//text()[not(parent::script)]");

            
            foreach (var textNode in textNodes)
            {

                var words = textNode.InnerText.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Where(s => Char.IsLetter(s[0]));
                // StringSplitOptions.RemoveEmptyEntries - Omit array elements that contain an empty string from the result.
                // and only count things starting with a letter.
                foreach(string word in words)
                {
                    allWords.Add(word);
                }
            }
            distinctWordCount = allWords.Distinct().Count();
            return distinctWordCount;
        }
    }
}
