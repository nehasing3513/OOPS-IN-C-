using System;
namespace program1
{
   public class overriding
   {
      public virtual void Area(int length, int breadth)
      {
         int ans = length*breadth;
         System.Console.WriteLine(ans);
      }
   }
   
   public class Dimension:overriding
   {
      public override void Area(int length, int breadth)
      {
         int height = Convert.ToInt32(Console.ReadLine());
         int ans = length*breadth*height;
         System.Console.WriteLine(ans);

      }
   }
   
}