using System;

namespace Wrox
{
   class MainEntryPoint
   {
      static void Main()
      {
         // Try calling some static functions
         Console.WriteLine("Pi is " + MathTest.GetPi());
         int x = MathTest.GetSquareOf(5);
         Console.WriteLine("Square of 5 is " + x);

         // Instantiate at MathTest object
         MathTest math = new MathTest();   
         

         math.Value = 30;
         Console.WriteLine(
            "Value field of math variable contains " + math.Value);
         Console.WriteLine("Square of 30 is " + math.GetSquare());
      }
   }


   class MathTest
   {
      public int Value;

      public int GetSquare()
      {
         return Value*Value;
      }

      public static int GetSquareOf(int x)
      {
         return x*x;
      }

      public static double GetPi()
      {
         return 3.14159;
      }
   }
}
