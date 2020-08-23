using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    class MamaSearcher : IMamaSearcher
    {
        public Dictionary<string,Action<int,string>> Stock { get; set; }

        public MamaSearcher(Dictionary<string, Action<int, string>> stock)
        {
            Stock = stock;
        }
        public void PerformSearch(string content)
        {

            int index;

            foreach(var v in Stock)
            {
                if (content.Contains(v.Key))
                {
                    index = content.IndexOf(v.Key);
                    v.Value(index,v.Key);
                    

;               }
            }

        }

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            Stock.Add(pattern, actionToPerform);
        }

    }
}
