namespace Event_Test2;
class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        Waiter waiter = new Waiter();
        customer.Order += waiter.Action;
        customer.Think();
    }
}
public class OrederEventArgs:EventArgs
{
    public string DishName { get; set; }

    public string Size { get; set; }
}
public delegate void OrderEventHandler(Customer customer, OrederEventArgs e);//eventhandler后缀 这个委托专门未来约束事件的

public class Customer
{
    private OrderEventHandler orderEventHandler;//委托类型的字段，来存储事件处理器

    public event OrderEventHandler Order
    {
        add
        {
            this.orderEventHandler += value;
        }
        remove
        {
            this.orderEventHandler -= value;
        }
    }

    public double Bill { get; set; }

    public void PayMyBill()
    {
        Console.WriteLine("I Will pay ${0}",this.Bill);
    }

    public void Think()
    {
        for(int i =0; i<5;i++)
        {
            Console.WriteLine("Thinking");
        }
        Thread.Sleep(1000);
        if (this.orderEventHandler!=null)
        {
            OrederEventArgs e = new OrederEventArgs();
            e.DishName = "chicken";
            e.Size = "large";
            this.orderEventHandler.Invoke(this,e);
        }
    }
}
public class Waiter
{
    public void Action(Customer customer, OrederEventArgs e)
    {
        Console.WriteLine("I will serve you the dish {0}",e.DishName);
    }
}