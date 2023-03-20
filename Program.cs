// See https://aka.ms/new-console-template for more information
using System;
using program1;
namespace Demo{

class programs{
public static void Main(String[] args)
{
    // System.Console.WriteLine("Hello world");

    //Abstraction
    // car obj1 = new car();
    // vehicle mycar = obj1;
    // mycar.speed();
    // mycar.color();
    // mycar.Display();

    // bike obj2 = new bike();
    // vehicle mybike = obj1;
    // mybike.speed();
    // mybike.color();
    // mybike.Display();

    //Inheritance
    // Doctor1 d = new Doctor1();
    // d.details();
    // d.details2();

    //Polymorphism:-
    //Method overloading
    // Console.WriteLine(overloading.Add(12,14));
    // Console.WriteLine(overloading.Add(10,18,10)); 

    //overriding
    Dimension obj2 = new Dimension();
    obj2.Area(10,20);
   
}


}
}
