class LambdaTest
{
    public static void Main()
    {
        //无参无返
        //lambda无法单独使用
        Action action = new Action(()=> Console.WriteLine("无参无返的lambda表达式"));
        //有参无返 省略方法体大括号
        Action<string> action1 = 
            (string msg) => Console.WriteLine(msg);
        action1.Invoke("w");

        //有参有返

        Func<int, int> func = (int i) =>
        {
            i++;
            return i;
        };
    }
}

