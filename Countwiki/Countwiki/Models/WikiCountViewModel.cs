using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Countwiki.Models
{
    public class WikiCountViewModel
    {
        [DisplayName("Wiki PAge URL")]
        public string WikiPageURL { get; set; }

        [DisplayName("Word Count")]
        public int WordCount { get; set; }
    }
}
