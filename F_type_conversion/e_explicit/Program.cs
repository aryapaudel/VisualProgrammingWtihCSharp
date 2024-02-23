namespace e_explicit;

class Program
{
    static void Main(string[] args)
    {
    //    double a=123.567;
    //    int b=(int)a;
    int a = 789;
    byte b = (byte)a;// carful about the range of byte i.e 0-255
       Console.WriteLine("int  value = "+a);
       Console.WriteLine("byte value = "+b);
       
    }
}







