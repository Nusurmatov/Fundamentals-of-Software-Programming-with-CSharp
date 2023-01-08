Console.Clear();

DoubleLinkedList<string> shoppingList = new DoubleLinkedList<string>();

shoppingList.Add("Milk");
shoppingList.Add("Honey");
shoppingList.Add("Olives");
shoppingList.Add("Water");
shoppingList.Add("Meat", false);

shoppingList.Insert("Apples", 0);
shoppingList.Insert("Bananas", 6);
shoppingList.Insert("Coffee", 3);

Console.Write(shoppingList);
Console.WriteLine("Size: {0}", shoppingList.Size);
Console.WriteLine("Is there milk in the list? {0}", shoppingList.Contains("Milk"));
Console.WriteLine("Index of honey: {0}", shoppingList.IndexOf("Honey"));
Console.WriteLine("Index of mango: {0}", shoppingList.IndexOf("Mango"));

foreach (var item in shoppingList)
{
    Console.Write($"{item} ");
}