using System;
  
namespace Wrox.ProCSharp.Basics
{
   public class ScopeTest
   {
      public static int Main()
      {
         for (int i = 0; i < 10; i++)
         {
            Console.WriteLine(i);
         }   
  
      
         for (int i = 9; i >= 0; i--)
         {
            Console.WriteLine(i);
         }   
         return 0;
      }
   }
}
