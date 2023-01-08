Console.Clear();

DoubleLinkedList<string> shoppingList = new DoubleLinkedList<string>();

shoppingList.Add("Milk");
shoppingList.Add("Honey");
shoppingList.Add("Olives", false);
shoppingList.Add("Water");
shoppingList.Add("Meat", false);

shoppingList.InsertAt("Apples", 0);
shoppingList.InsertAt("Bananas", 6);
shoppingList.InsertAt("Coffee", 3);

Console.Write(shoppingList);
Console.WriteLine("Item at position 3: {0}", shoppingList.GetAt(3));
Console.WriteLine("Item at position 4: {0}", shoppingList[4]);
Console.WriteLine("Size: {0}", shoppingList.Size);
Console.WriteLine("Is there milk in the list? {0}", shoppingList.Contains("Milk"));
Console.WriteLine("Index of honey: {0}", shoppingList.IndexOf("Honey"));
Console.WriteLine("Index of mango: {0}\n", shoppingList.IndexOf("Mango"));

shoppingList.Remove("Apples");
shoppingList.Remove("Honey");
shoppingList.Remove("Bananas");
shoppingList.Remove("Bananas");
shoppingList.RemoveAt(1);

Console.WriteLine("Size: {0}", shoppingList.Size);
string[] array = shoppingList.ToArray<string>();

foreach (var item in array)
{
    Console.Write($"{item} ");
}