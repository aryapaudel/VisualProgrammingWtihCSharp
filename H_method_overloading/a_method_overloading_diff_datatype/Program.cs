namespace a_method_overloading_diff_datatype;
#nullable disable
using System;
class Sum
{
    // adding three integer values.
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }
    // adding three double values.
    public double Add(double a,
     double b, double c)
    {
        double sum = a + b + c;
        return sum;
    }

    public static void Main(String[] args)
    {

        Sum obj = new Sum();
        int sum2 = obj.Add(1, 2, 3);
        Console.WriteLine("sum of the three integer value : " + sum2);
        double sum3 = obj.Add(1.5, 2.7, 3.0);
        Console.WriteLine("sum of the three  double value : " + sum3);
    }
}
