namespace BuiltInDataStructure
{
    public static class StackAndQueue
    {
        public static string ExpressionForStackDemo { get; set; } = "1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))";

        public static int N { get; set; } = 3;

        public static int Value { get; set; } = 16;

        public static void DemoStackContent()
        {
            Stack<int> stack = new Stack<int>();
            bool correctBrackets = true;
            Console.WriteLine("Expression: {0}", ExpressionForStackDemo);
            
            for (int index = 0; index < ExpressionForStackDemo.Length; index++)
            {
                char ch = ExpressionForStackDemo[index];
                if (ch == '(')
                {
                    stack.Push(index);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }

                    stack.Pop();
                }
            }

            if (stack.Count != 0)
            {
                correctBrackets = false;
            }
    
            Console.WriteLine("Are the brackets correct? - {0}", correctBrackets);
        }

        public static void DemoQueueContent()
        {
            Console.WriteLine("---------- Sequence N, N+1, 2*N - Demo ---------");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(N);
            int index = 0;
            
            Console.Write("S =");
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.Write($" {current}");
                if (current == Value)
                {
                    Console.WriteLine();
                    Console.WriteLine("Index = " + index);
                    return;
                }
            
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }
        }
    }
}