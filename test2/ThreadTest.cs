using System;
namespace test2
{
	public class ThreadTest
	{
		public ThreadTest()
		{

		}
		public static void Main()
		{
			Thread t = new Thread(Print);
			t.Start("12");
		}
		static void Print(object mess)
		{
			string messa = (string)mess;
            Console.Write(messa);
		}
	}
	
}

