CustomArrayList<string> shoppingList = new CustomArrayList<string>();
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

Console.WriteLine("We need to buy:");
for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(" - " + shoppingList[i]);
}

Console.WriteLine("Position of 'Beer' = {0}", shoppingList.IndexOf("Beer"));
Console.WriteLine("Position of 'Water' = {0}", shoppingList.IndexOf("Water"));
Console.WriteLine("Do we have to buy Bread? {0}", shoppingList.Contains("Bread"));

/* Output:
We need to buy:
 - Milk
 - Fruits
 - Honey
 - A lot of Water
 - Beer
 - Vegetables
Position of 'Beer' = 4        
Position of 'Water' = -1      
Do we have to buy Bread? False
*/