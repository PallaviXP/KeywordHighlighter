using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class KeywordController
    {
        public KeywordController()
        {
            Keywords = new List<string>() {"if", "as", "and", "then", "when"};

        }
        public List<string> Keywords { get; set;}
        public string HighlightKewords(string input)
        {
            var inputSplitted = input.Split(' ');
           /* var changedInput = inputSplitted.Select(x=> {
                if(Keywords.Contains(x))
                    x = "[blue]" + x  + "[blue]";
                    return x;
               }
                ).ToList();*/

           for(int i=0; i<inputSplitted.Length; i++)
           {
               if(Keywords.Contains(inputSplitted[i]))
                    inputSplitted[i] = "[blue]" + inputSplitted[i]  + "[blue]";
           }
        
            return  string.Join(" ", inputSplitted);
        }
    }
}
