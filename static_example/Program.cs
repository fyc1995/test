namespace static_example;
class Program
{
    static int a,b;
    static void Main(string[] args)
    {
        Entity entity = new Entity();
        entity.a = 1;
        entity.b = 2;
        Entity.x = 1;
        Entity.y = 2;
    }
}
class Entity
{
    public static int x, y;
    public int a, b;
}

