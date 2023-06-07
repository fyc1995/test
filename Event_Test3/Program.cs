namespace Event_Test3;
class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();//事件的拥有者
        Waiter waiter = new Waiter();
        customer.Order += new OrderEventHandler(waiter.Action);
       // customer.Order += waiter.Action;//添加到事件处理器
        customer.Think();
    }
}
public class OrederEventArgs : EventArgs
{
    public string DishName { get; set; }

    public string Size { get; set; }
}
public delegate void OrderEventHandler(Customer customer, OrederEventArgs e);//eventhandler后缀 这个委托专门未来约束事件的

public class Customer
{
    // private OrderEventHandler orderEventHandler;//委托类型的字段，来存储事件处理器

    public event OrderEventHandler Order;//不是字段     

    

    public double Bill { get; set; }

    public void PayMyBill()
    {
        Console.WriteLine("I Will pay ${0}", this.Bill);
    }

    public void Think()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thinking");
        }
        Thread.Sleep(1000);
        if (this.Order != null)
        {
            OrederEventArgs e = new OrederEventArgs();
            e.DishName = "chicken";
            e.Size = "large";
          //  this.Order.Invoke(this, e);
        }
    }
}
public class Waiter
{
    public void Action(Customer customer, OrederEventArgs e)
    {//事件的响应方法
        Console.WriteLine("I will serve you the dish {0}", e.DishName);
    }
}
