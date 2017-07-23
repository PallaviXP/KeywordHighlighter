 using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
   
 public class Keyword{

        public Keyword(string word, string highlighter, StringCaseType caseType, WordStyleType style)
        {
                this.Word = word;
                this.HighlighterColor = highlighter;
                this.CaseType = caseType;
                this.WordStyle = style;
        }
        public string Word { get; set;}
        public string HighlighterColor { get; set;}

        public StringCaseType CaseType { get; set; }

         public WordStyleType WordStyle { get; set; }

       public string FormatWord()
       {
           string input = this.Word;
           if(this.CaseType == StringCaseType.capital)
              input = input.ToUpper();
           else
              input = input.ToLower();
           if(this.WordStyle == WordStyleType.bold)
              input = $"[bold]{input}[bold]";
           return $"[{HighlighterColor}]{input}[{HighlighterColor}]";           
       }
    }
}