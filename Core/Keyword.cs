 using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
   
 public class Keyword{

        public Keyword(string word, string highlighter, StringCaseType caseType)
        {
                this.Word = word;
                this.HighlighterColor = highlighter;
                this.CaseType = caseType;
        }
        public string Word { get; set;}
        public string HighlighterColor { get; set;}

        public StringCaseType CaseType { get; set; }

       public string FormatWord()
       {
           string input = this.Word;
           if(this.CaseType == StringCaseType.capital)
              input = input.ToUpper();
           else
              input = input.ToLower();
           return $"[{HighlighterColor}]{input}[{HighlighterColor}]";           
       }
    }
}