using System.Collections;

namespace BuiltInDataStructure
{
    public static class DynamicArrayList
    {
        public static void DemoArrayListContent()
        {
            ArrayList list = new ArrayList(); // untyped dynamically-extendable array
            list.Add("Hello");
            list.Add(5);
            list.Add(3.14159);
            list.Add(DateTime.Now);

            for (int i = 0; i < list.Count; i++)
            {
                object? value = list[i];
                Console.WriteLine("Index={0}; Value={1}", i, value);
            }

            // C# dynamic Demo
            Console.WriteLine("-------------------//-----//-------------------");
            list.Clear();
            list.Add(2);
            list.Add(3.5f);
            list.Add(25u);
            list.Add(" EUR");

            dynamic sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                dynamic? value = list[i];
                sum = sum + value;
            }
 
            Console.WriteLine("Sum = " + sum); // Output: Sum = 30.5 EUR            
        }
    }
}