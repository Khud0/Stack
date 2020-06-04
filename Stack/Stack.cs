using System;
using System.Collections;

namespace Stack
{
    class Stack
    {
        private ArrayList list = new ArrayList();

        public void Push(object obj)
        {
            if (obj == null) { throw new InvalidOperationException("You can't add null to the stack!"); }

            list.Add(obj);
        }

        public object Pop()
        {
            if (list.Count == 0) { throw new InvalidOperationException("Stack is empty!"); }

            int lastIndex = list.Count - 1;
            object returnObject = list[lastIndex];
            list.RemoveAt(lastIndex);

            return returnObject;
        }

        public void Clear()
        {
            if (list.Count > 0) 
            {
                Console.WriteLine("Stack was cleared.");
                list = new ArrayList();
            }
        }

        public void PrintStatus()
        {
            int count = list.Count;

            Console.WriteLine($"\nNumber of objects on Stack: {count}");
            for (int i=0; i<count; i++)
            {
                Console.WriteLine($"#{i+1}: {list[i].ToString()}");
            }
            Console.WriteLine();
        }
    }
}
