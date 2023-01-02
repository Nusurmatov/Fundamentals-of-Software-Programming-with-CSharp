/* Ex5 - Properties (Variable Number of Arguments and Overloading):
Depending on their definition we can classify the properties as follows:
1. Read-only, i.e. these properties have only a get method as shown by
the area of the rectangle.
2. Write-only, i.e. these properties have only a set method, but no
method for reading the value of the property.
3. And the most common case is read-write, where the property has
methods both for reading and for changing the value.
*/

class Rectangle
{
    private float height;
    private float width;

    public Rectangle(float height, float width)
    {
        this.height = height;
        this.width = width;
    }

    // Obtaining the value of the property area
    public float Area
    {
        get { return this.height * this.width; }
    }
}

public class Dog
{
    int age;
    public int Age
    {
        get { return this.age; }
        set
        {
            // Take precaution: perform check for correctness
            if (value < 0)
            {
                throw new ArgumentException("Invalid argument: Age should be a positive number.");
            }

            // Assign the new correct value
            this.age = value;
        }
    }
}

class Point
{
    // automatic properties
    public double X { get; set; }
    public double Y { get; set; }

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}

/* Output:

*/