using System;
using System.Collections.Generic;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>()
                {
                    new string("Then let not winter's ragged hand deface"),
                    new string("In thee thy summer, ere thou be distill'd:"),
                    new string("Make sweet some vial; treasure thou some place"),
                    new string("With beauty's treasure, ere it be self-kill'd.")
                };
            StringSearcher stringSearcher = new StringSearcher(strings);            
            string word = "thou";
            stringSearcher.InfoAboutString();
            stringSearcher.Message += DisplayMessage;
            stringSearcher.Search(word, strings.ToArray());
        }
        public static void DisplayMessage(StringSearcher sender, StringHandler e) => Console.WriteLine($"{e.Message}\n");
    }
}
