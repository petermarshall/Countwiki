﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countwiki.Services
{
    public class WordCounter
    {
        public WordCounter()
        {

        }

        public int Count (string html)
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // work with the body and ignore the rest
            var body = htmlDocument.DocumentNode.SelectSingleNode("//body");

            // selecting just text nodes you may get javascript in ther as well.
            // so "//text()[not(parent::script)]" eliminates the javscript from the count
            var textNodes = body.SelectNodes("//text()[not(parent::script)]");

            int wordCount = 0;
            foreach (var textNode in textNodes)
            {

                var words = textNode.InnerText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // StringSplitOptions.RemoveEmptyEntries - Omit array elements that contain an empty string from the result.                
                    
                int wordsInNode = words.Count();

                wordCount += wordsInNode;
            }
            return wordCount;
        }
    }
}