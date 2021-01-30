using System;
namespace input
{
  class input
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Whats your name?");
      string name = Console.ReadLine();
      Console.WriteLine("Whats your age?");
      string agestr = Console.ReadLine();
      int age = Convert.ToInt32(agestr);
      Console.WriteLine("Has your birthday happened yet this year? yes/no");
      string bdayHappened = Console.ReadLine();
      if (bdayHappened != "yes")
      {
        if (bdayHappened != "no")
        {
          Console.WriteLine("Oops, that wasn't an option, try again.");
        bdayHappened = Console.ReadLine();
        }
      }
      Console.WriteLine("Whats the current year?");
      string yearstr = Console.ReadLine();
      int year = Convert.ToInt32(yearstr);
      int byear = 0;
      if (bdayHappened == "yes")
      {
        byear = year - age;
      }
      else
      {
        byear = year - age - 1;
      }
      Console.WriteLine($"Your name is {name} and you were born in the year {byear}.");
      Console.WriteLine("Press enter to exit");
      Console.ReadLine();
    }
  }
}
