//定义委托
delegate int Cal(int x,int y);

delegate int Cal2(int x,int y);
class Test
{
    static event Cal CalEvent;
    
    static int PrintNum(int x,int y)
    {
        Console.WriteLine(x);
        return x;
    }
    static int sum(int x,int y)
    {
        Console.WriteLine(x+y);
        return x + y;
    }
    static int dec(int x, int y)
    {
        Console.WriteLine(x-y);
        return x - y;
    }
    static int test1(Cal f)
    {
        Console.WriteLine("请输入");
        int x = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("请输入");
        int y = Convert.ToInt16(Console.ReadLine());
        //f.Invoke();
        return f(x, y);
    }
    static void Main()
    {
        //实例化委托+注册方法到委托中
        Cal2 cal2 = new Cal2(PrintNum);
        Cal cal = new Cal(sum);
       
        //cal += dec;
        //cal(1,2);
        Boy boy = new Boy();
        CalEvent += Boy.calSum;
        CalEvent(1, 2);
        //用法1. 委托当作参数传递到方法中，只需修改传入到委托，不需要修改该方法。
      //  int res = test1(new Cal(sum));
        //test1(sum);
    }
}
class Boy
{
    internal static int calSum(int x, int y)
    {
        Console.WriteLine(x+y);
        return x + y;
    }
}

