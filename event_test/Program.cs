
using System.Timers;
using Timer = System.Timers.Timer;

namespace event_test;
class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");
        Timer timer = new Timer();//拥有者
        timer.Interval = 1000;
        Boy boy = new Boy();//响应者
        timer.Elapsed += boy.Action;//事件 += 事件处理器
        timer.Start();
        Console.ReadLine();
    }
}
class Boy
{
    //事件处理器
    internal void Action(object? sender, ElapsedEventArgs e)
    {
        Console.WriteLine("jump");
    }
}