using System;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args) // void signifies that the reutrn of this executable method will be void and static implies that the scope of this method is at the class level, not the object level, and can this be invoked without having to first create a new class instance.Hence the Main() method can be run as soon as the program runs.
    // you could also intilize like static void Main() which has no parameters
    {
        float side1 = 3.14F; //you can use double here as well, but it is twice the program size. floats are good for ~6 decimals and double is used for ~15 decimals. end the value with F or D respectively
        float area1 = side1 * side1;
        Console.WriteLine("Area: {0}", area1);
        Console.WriteLine("area is a: {0}", area1.GetType());

        double side2 = 3.14D; //it is best practice to use doubles, as they have a much higher precision, going out to 15 decimal places
        double area2 = side2 * side2;
        Console.WriteLine("Area: {0}", area2);
        Console.WriteLine("area is a: {0}", area2.GetType());
    }
  }
}