namespace b_method_overloading_diff_sequence;

using System;
class Student
{
    public void Info(String name, int id)
    {

        Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
    }
    public void Info(int id, String name)
    {

        Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
    }
    public static void Main(String[] args)
    {
        Student obj = new Student();
        obj.Info("Hari", 1);
        obj.Info(2, "Shyam");
    }
}
