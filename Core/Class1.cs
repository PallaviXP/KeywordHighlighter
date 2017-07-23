using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{ 
   
    public class KeywordController
    {
        public KeywordController()
        {
            Keywords = new List<Keyword>
                { new Keyword("if", "red", StringCaseType.lower, WordStyleType.bold), 
                new Keyword("as", "blue", StringCaseType.capital, WordStyleType.normal), 
                new Keyword("and", "red", StringCaseType.capital, WordStyleType.bold), 
                new Keyword("then", "green", StringCaseType.lower, WordStyleType.normal), 
                new Keyword("when", "blue", StringCaseType.lower, WordStyleType.normal)            
            };
        }
        public List<Keyword> Keywords { get; set;}
        public string HighlightKewords(string input)
        {
            var inputSplitted = input.Split(' ');
        
           var output = inputSplitted.Select(x=> {               
               var matchedKeyword = Keywords.FirstOrDefault(y=> y.Word == x);
               if(matchedKeyword != null)
                  x =  matchedKeyword.FormatWord();
               return x;
            });
        
            return  string.Join(" ", output);
        }
    }
}
