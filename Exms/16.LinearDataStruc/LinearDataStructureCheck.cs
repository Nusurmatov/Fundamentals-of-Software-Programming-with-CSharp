using CustomList;
using BuiltInDataStructure;

namespace LinearDataStructure
{
    public static class LinearDataStructureCheck
    {
        public static void Main()
        {
            Console.Clear();
            bool undone = true;
            var consoleOutput = new System.Text.StringBuilder();
            
            consoleOutput.AppendLine("Enter c -> CustomArrayList");
            consoleOutput.AppendLine("      d -> DynamicList");
            consoleOutput.AppendLine("      a -> ArrayList");
            consoleOutput.AppendLine("      l -> List");
            consoleOutput.AppendLine("      s -> Stack");
            consoleOutput.AppendLine("      q -> Queue");
            consoleOutput.Append("      e -> Exit Program : ");

            while (undone)
            {
                Console.Write(consoleOutput);
                ConsoleKeyInfo input = Console.ReadKey();
                Console.Clear();

                switch (input.Key)
                {
                    case ConsoleKey.D: DemoCustomListContent(1); break;
                    case ConsoleKey.A: DynamicArrayList.DemoArrayListContent(); break;
                    case ConsoleKey.L: GenericList.DemoeGenericListContent(); break;
                    case ConsoleKey.S: StackAndQueue.DemoStackContent(); break;
                    case ConsoleKey.Q: StackAndQueue.DemoQueueContent(); break;
                    case ConsoleKey.E: undone = false; break;
                    default: DemoCustomListContent(0); break;
                }

                Console.WriteLine();
            }
        }

        private static void DemoCustomListContent(int input)
        {
            CustomList<string> shoppingList = (input == 1) ?
                    new DynamicList<string>() : new CustomArrayList<string>();

            shoppingList.Add("Milk");
            shoppingList.Add("Honey");
            shoppingList.Add("Olives");
            shoppingList.Add("Water");
            shoppingList.Add("Beer");

            shoppingList.Remove("Olives");

            shoppingList.Insert("Fruits", 1);
            shoppingList.Insert("Cheese", 0);
            shoppingList.Insert("Vegetables", 6);

            shoppingList.RemoveAt(0);
            shoppingList[3] = "A lot of " + shoppingList[3];

            Console.WriteLine("\nWe need to buy:");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(" - " + shoppingList[i]);
            }

            Console.WriteLine("Position of 'Beer' = {0}", shoppingList.IndexOf("Beer"));
            Console.WriteLine("Position of 'Water' = {0}", shoppingList.IndexOf("Water"));
            Console.WriteLine("Do we have to buy Bread? {0}", shoppingList.Contains("Bread"));
        }
    }
}