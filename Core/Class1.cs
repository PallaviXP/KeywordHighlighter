using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class Keyword{

        public Keyword(string word, string highlighter)
        {
                this.Word = word;
                this.HighlighterColor = highlighter;
        }
        public string Word { get; set;}
        public string HighlighterColor { get; set;}
    }
    public class KeywordController
    {
        public KeywordController()
        {
            Keywords = new List<Keyword>
            { new Keyword("if", "red"), 
            new Keyword("as", "blue"), 
            new Keyword("and", "red"), 
            new Keyword("then", "green"), 
            new Keyword("when", "blue")
            
            };

        }
        public List<Keyword> Keywords { get; set;}
        public string HighlightKewords(string input)
        {
            var inputSplitted = input.Split(' ');
        
           var output = inputSplitted.Select(x=> { 
               
               var G = Keywords.FirstOrDefault(y=> y.Word == x);
               if(G != null)
                   x= $"[{G.HighlighterColor}]{x}[{G.HighlighterColor}]";
               return x;
            });
        
            return  string.Join(" ", output);
        }
    }
}
