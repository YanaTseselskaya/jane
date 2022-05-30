using System;
using System.Collections.Generic;

namespace Strings
{
    public class StringSearcher
    {
        public delegate void StringSearcherHandler (StringSearcher sender, StringHandler e);
        public event StringSearcherHandler Message;
        
        private readonly List<string> _strings;
        public StringSearcher(List<string> strings) => _strings = strings;
        public StringSearcher(params string[] strings) => _strings.AddRange(strings);
        public void Search(string word, params string[] strings)
        {
            for(int i = 0; i < _strings.Count; i++)
            {
                bool b = strings[i].Contains(word);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("{0} : {1} => ", word, b ? "true" : "false");
                Console.ResetColor();
                if (b)                
                    Message?.Invoke(this, new StringHandler ($" => {strings[i]}"));                
                else
                    Console.WriteLine($"В строке '{strings[i]}' не найдено слово '{word}'\n");
            }            
        }
        public void InfoAboutString()
        {
            foreach (var strings in _strings)
                Console.WriteLine($"{strings}\n");           
        }
    }
}
