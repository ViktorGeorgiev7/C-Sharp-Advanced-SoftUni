using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings:Stack<string>
    {
        public bool IsEmpty()
        {
            
            return this.Count == 0;
        }

        public Stack<string> AddRange(IEnumerable<string> elements)
        {
            foreach (var el in elements)
            {
                Push(el);
            }

            return this;
        }
    }
}
