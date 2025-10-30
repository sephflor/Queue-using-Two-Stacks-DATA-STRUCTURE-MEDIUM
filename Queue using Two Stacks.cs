using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());

        Stack<int> stackNewest = new Stack<int>(); // Enqueue stack
        Stack<int> stackOldest = new Stack<int>(); // Dequeue stack

        for (int i = 0; i < q; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int type = Convert.ToInt32(input[0]);

            if (type == 1)
            {
                int value = Convert.ToInt32(input[1]);
                stackNewest.Push(value);
            }
            else if (type == 2)
            {
                ShiftStacks(stackNewest, stackOldest);
                if (stackOldest.Count > 0)
                    stackOldest.Pop();
            }
            else if (type == 3)
            {
                ShiftStacks(stackNewest, stackOldest);
                if (stackOldest.Count > 0)
                    Console.WriteLine(stackOldest.Peek());
            }
        }
    }

    static void ShiftStacks(Stack<int> stackNewest, Stack<int> stackOldest)
    {
        if (stackOldest.Count == 0)
        {
            while (stackNewest.Count > 0)
            {
                stackOldest.Push(stackNewest.Pop());
            }
        }
    }
}
