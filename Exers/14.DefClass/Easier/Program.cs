// (Easier) Ex1,2,3,4,5,6,7 - Student Class (Test):

public enum Subjects { Math, CS, Physics, DataScience };
    
public enum Universities { Cambridge, Oxford, Harvard, MIT };

public class Student
{
    private const string defaultValue = "missing..."; 
    private string FullName { get; set; }
    private Universities University { get; set; } 
    private Subjects Subject { get; set; }
    private string Course { get; set; }
    private string Email { get; set; }
    private string PhoneNumber { get; set; }

    private static int StudentsCount;

    public Student(string fullName, Universities university, Subjects subject = Subjects.CS)
        : this(fullName, university, subject, defaultValue) { }

    public Student(string fullName, Universities university, Subjects subject, string course)
        : this (fullName, university, subject, course, defaultValue) { }

    public Student(string fullName, Universities university, Subjects subject, string course, string email, string phoneNumber = defaultValue)
    {
        this.FullName = fullName;
        this.University = university;
        this.Subject = subject;
        this.Course = course;
        this.Email = email;
        this.PhoneNumber = phoneNumber;
        IncreaseStudent();
    }

    public void GetInfo()
    {
        Console.WriteLine("Student Full Name: {0}", FullName);
        Console.WriteLine("University: {0}", University);
        Console.WriteLine("Subject: {0}", Subject);
        Console.WriteLine("Course: {0}", Course);
        Console.WriteLine("Email: {0}", Email);
        Console.WriteLine("Phone Number: {0}", PhoneNumber);
    }

    private void IncreaseStudent()
    {
        StudentsCount++;
    }
}

public class StudentTest
{
    private static Student[] students;
    private static int totalStudents;

    public static Student[] Students { get { return students; } set { students = value; } }

    public static int TotalStudents { get {return totalStudents; } set { totalStudents = value; } }

    private static void Main()
    {
        TotalStudents = 3;
        CreateStudents(TotalStudents);
    }

    public static void CreateStudents(int n)
    {
        Students = new Student[n];
        Random ran = new Random();

        for (int i = 0; i < n; i++)
        {
            Students[i] = new Student($"Student{i+1}", (Universities) ran.Next(4));
            Students[i].GetInfo();
        }
    }
}

/* Input/Output:
Student Full Name: Student1
University: Oxford
Subject: CS
Course: missing...
Email: missing...
Phone Number: missing...   
Student Full Name: Student2
University: MIT
Subject: CS
Course: missing...
Email: missing...
Phone Number: missing...   
Student Full Name: Student3
University: MIT
Subject: CS
Course: missing...
Email: missing...
Phone Number: missing...
*/