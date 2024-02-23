namespace d_parameterized_constructor;
#nullable disable
class Student
{
    int roll;
    String name;
    public Student(int r, string n)
    {
        roll = r;
        name = n;
    }
    // public void getInput()
    // {
    //     System.Console.WriteLine("Enter your rollno: ");
    //     int r = Convert.ToInt32(Console.ReadLine());
    //     System.Console.WriteLine("Enter your name: ");
    //     string n = Console.ReadLine();

    // }

    public void displayResult()
    {
        System.Console.WriteLine("Your roll no is " + r);
        System.Console.WriteLine("Your name is " + n);
    }
}
class Program
{
    static void Main(string[] args)
    {
        int sr;
        string sn;
        System.Console.WriteLine("Enter roll no: ");
        sr=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter your name:");
        sn=Console.ReadLine();
        Student s1 = new Student(sr,sn);
        // s1.getInput();
        s1.displayResult();
    }
}
