using System;

namespace Wrox
{
   class MainEntryPoint
   {
      static void Main()
      {
         WeakReference mathReference = new WeakReference(new MathTest());   
         MathTest math;
         if(mathReference.IsAlive)
         {
            math = mathReference.Target as MathTest;
            math.Value = 30;
            Console.WriteLine(
               "Value field of math variable contains " + math.Value);
            Console.WriteLine("Square of 30 is " + math.GetSquare());

         }
         else
         {
            Console.WriteLine("Reference is not available.");
         }

         GC.Collect();
         
         if(mathReference.IsAlive)
         {
            math = mathReference.Target as MathTest;
         }
         else
         {
            Console.WriteLine("Reference is not available.");
         }
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
