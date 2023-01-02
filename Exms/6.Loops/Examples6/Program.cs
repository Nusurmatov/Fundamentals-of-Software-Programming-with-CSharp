/* 
Nested-loops - In the following example we will find all possible combinations of the
lottery game "6/49". We have to find and print all possible extracts of 6
different numbers, each of which is in the range [1…49]. We will use 6 forloops. 
Unlike the previous example, the numbers cannot be repeated. To
avoid repetitions we will strive for each subsequent number to be larger than
the previous. Therefore, the internal loops will not start from 1 but from the
number to which the previous loop got + 1. We will have to go through the
first loop until it reaches 44 (and not to 49), the second – 45, etc. The last
loop will be up to 49. If you make all loops to 49 you will receive matching
numbers in certain combinations. For the same reason, each subsequent cycle
starts from the previous loop counter + 1. Let’s see what will happen:
*/

for (int i1 = 1; i1 <= 44; i1++)
{
    for (int i2 = i1 + 1; i2 <= 45; i2++)
    {
        for (int i3 = i2 + 1; i3 <= 46; i3++)
        {
            for (int i4 = i3 + 1; i4 <= 47; i4++)
            {
                for (int i5 = i4 + 1; i5 <= 48; i5++)
                {
                    for (int i6 = i5 + 1; i6 <= 49; i6++)
                    {
                        Console.WriteLine(i1 + " " + i2 + " " +
                        i3 + " " + i4 + " " + i5 + " " + i6);
                    }
                }
            }
        }
    }
}

/*  Input/Output:
..............
1 2 9 20 24 26
1 2 9 20 24 27
1 2 9 20 24 28
1 2 9 20 24 29
1 2 9 20 24 30
1 2 9 20 24 31
..............
 */