using System;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args) // void signifies that the reutrn of this executable method will be void and static implies that the scope of this method is at the class level, not the object level, and can this be invoked without having to first create a new class instance.Hence the Main() method can be run as soon as the program runs.
    // you could also intilize like static void Main() which has no parameters
    {
      Console.WriteLine("Hello, World!");
    }
  }
}