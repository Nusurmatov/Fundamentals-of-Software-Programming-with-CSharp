// Special String Comparision
string str = "beer";
string anotherStr = str;
string thirdStr = "bee";
thirdStr = thirdStr + 'r';
Console.WriteLine("str = {0}", str);
Console.WriteLine("anotherStr = {0}", anotherStr);
Console.WriteLine("thirdStr = {0}", thirdStr);
Console.WriteLine(str == anotherStr); // True - same object
Console.WriteLine(str == thirdStr); // True - equal objects
Console.WriteLine((object)str == (object)anotherStr); // True
Console.WriteLine((object)str == (object)thirdStr); // False


// Using Multiple Levels in switch-case structure
int number = 6;
switch (number)
{
    case 1:
    case 4:
    case 6:
    case 8:
    case 10:
        Console.WriteLine("The number is not prime!"); break;
    case 2:
    case 3:
    case 5:
    case 7:
        Console.WriteLine("The number is prime!"); break;
    default:
        Console.WriteLine("Unknown number!"); break;
}

/* Ouput:
The number is not prime!
 */