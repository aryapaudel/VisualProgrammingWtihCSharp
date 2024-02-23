namespace constructor_overloading_diff_num_para;
#nullable disable
class nums{
    int m,n;
    int p,q,r;
    public nums(int a,int b){
        m=a;
        n=b;

    }
    public nums(int x,int y, int z){
        p=x;
        q=y;
        r=z;
    }
    public void displaySum(){
         Console.WriteLine("The sum= "+(m+n));
    }
    public void displayProduct(){
        Console.WriteLine("The product = "+(p * q * r));
    }
}



class Program
{
    static void Main(string[] args)
    {
        nums n1=new nums(5,4);
        nums n2=new nums(1,2,3);
        n1.displaySum();
        n2.displayProduct();
    }
}
