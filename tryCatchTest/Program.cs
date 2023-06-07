class TryCatchTest
{
    static void Main()
    {
        test();
    }
    public static void test()
    {
        int x = 0;
        int y = 1;
        try
        {
            int r = y / x;
          //throw new Exception("paochuyichang");
            Console.WriteLine("12");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        
    }

}

