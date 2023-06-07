//delegate void p();
class Program
{
    public static void Main()
    {
        Box box = new Box();
        WrapFactory wrap = new WrapFactory();
        ProductFactory productFactory = new ProductFactory();
        //productFactory.MakeToyBear;
        try
        {
            box = wrap.wrapProduct(productFactory.MakeToyBear);
            Console.WriteLine(box.Product.Name);
        }
        catch (Exception ex)
        {
            Console.WriteLine("567");
        }
        
    }

}

class Box
{
    public Product Product
    {
        get;
         set;
    }
}
class Product
{
    public string Name { get; set; }
}
//玩具厂负责生产玩具
class ProductFactory
{
    public Product MakeToyCar()
    {
        Product product = new Product();
        product.Name = "ToyCar";
        return product;
    }
    public Product MakeToyBear ()
    {
        Product product = new Product();
        product.Name = "ToyBear";
        return product;
    }
}
class WrapFactory
{
    public Box wrapProduct(Func<Product> getProduct)

    {
        Box box = new Box();
        try
        { 
            Product product = getProduct.Invoke();
            box.Product = product;
            throw new Exception();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message+"报错");
        }
        
        return box;
    }
}