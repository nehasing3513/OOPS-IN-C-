using System;
namespace program1
{


    public abstract class vehicle
    {
        public abstract void speed();
        public abstract void color();
        public void Display(){
            Console.WriteLine("This is my Favourite vehicle");
        }
    }

    public class car:vehicle
    {
        public override void speed()
        {
            Console.WriteLine("Enter the distance:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time taken:");
            int t = Convert.ToInt32(Console.ReadLine());
            int s = d/t;

            System.Console.WriteLine("speed of car is :{0} ",s);
        }

        public override void color()
        {
            Console.WriteLine("Color of the car is red");
        }
    }

    public class bike:vehicle
    {
        public override void speed()
        {
            Console.WriteLine("Enter the distance:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time taken:");
            int t = Convert.ToInt32(Console.ReadLine());
            int s = d/t;

            System.Console.WriteLine("speed of bike is :{0}",s);
        }

        public override void color()
        {
            Console.WriteLine("Color of the bike is blue");
        }
    }
}