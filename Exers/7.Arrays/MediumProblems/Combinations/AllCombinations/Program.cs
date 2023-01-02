/* (Medium Problems) Ex23, 24 - Problem Statments: */
string problem23 = "23. Write a program, which reads the integer numbers N and K from the console and prints all variations"
+ "\nof K elements of the numbers in the interval [1…N]. Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}," 
+ "\n{2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}.\n";
string problem24 = "24. Write a program, which reads an integer number N from the console and prints all combinations of K"
+ "\nelements of numbers in range [1 … N]. Example:N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3},"
+"\n{2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}.\n";

bool unDonce = true;
while (unDonce)
{
    ConsoleColor back = ConsoleColor.White;
    ConsoleColor front = ConsoleColor.DarkGreen;
    Console.BackgroundColor = back;
    Console.ForegroundColor = front;
    Console.Clear();

    int exerciseNum = 23;
    Console.Write("Enter the exercise number (23 or 24): ");
    while (true)
    {
       if (int.TryParse(Console.ReadLine(), out exerciseNum) && (exerciseNum == 23 || exerciseNum == 24))
       {
            switch (exerciseNum)
            {
                case 23:
                    Console.Clear();
                    Console.Write(problem23);
                    break;
                case 24:
                    Console.Clear();
                    Console.Write(problem24);
                    break;
            }
            
            break;
       }
       else
       {
            Console.Write("Invalid input...! Enter 23 or 24: ");
       }
    }

    int n = 3, k = 2;
    Combinations combination = new Combinations();

    Console.Write("N = ");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            break;
        }
        else
        {
            Console.Write("Invalid input...! N should be integer and greater than 0, N = ");
        }
    }

    Console.Write("K = ");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out k) && k > 0)
        {
            break;
        }
        else
        {
            Console.Write("Invalid input...! K should be integer and greater than 0, K = ");
        }
    }
    
    int[] array = new int[k];
    Console.WriteLine($"N = {n}, K = {k}:");
    if (exerciseNum == 23)
    {
        combination.AllCombinationsInInterval(array, n, k);
    }
    else
    {
        combination.AllCombinationsInRange(array, n, k);
    }

    Console.Write("\n\nPress any key to continue or 'q' to exit: ");
    string key = Console.ReadLine() ?? "c";
    Console.WriteLine(key);

    if (key.ToLower() == "q")  // just in case the Caps Lock is on.
    {
        unDonce = false;
        Console.Clear();
        Console.WriteLine("The end...! ");
    }
}

/* Input/Output:


*/