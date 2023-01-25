//this is output section 
namespace output
{
  class prac2
  {
    public static void sum()
    {
      Console.WriteLine("Value 1");
      int val1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Value 2");
      int val2 = Convert.ToInt32(Console.ReadLine());
      int sum = val1 + val2;

      Console.WriteLine("The sum is " + sum + ".");
    }
    public static void divide()
    {
      Console.WriteLine("Value 1");
      int val1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Value 2");
      int val2 = Convert.ToInt32(Console.ReadLine());
      int sum = val1 / val2;
      Console.WriteLine("the result is " + sum + ".");

    }
  }
}
