namespace program1
{
    public class Doctor
    {
        
        public void details()
        {
            System.Console.WriteLine("This is a parent class");
        }
    }

    public class Doctor1:Doctor
    {
         public void details2()
        {
            System.Console.WriteLine("This is a child  class");
        }
    }
    
}