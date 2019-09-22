using System;
  
namespace Wrox
{
   public class ScopeBad
   {
		public static int Main()
		{
		   int j = 20;
		   for (int i = 0; i < 10; i++)
		   {
			  int j = 30;   
			  Console.WriteLine(j + i);
		   }
		   return 0;
		}
	}
}

