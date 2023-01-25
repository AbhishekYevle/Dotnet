using System;
using System.Reflection;

namespace safeFile
{
  class Privateclass
  {
    private void MyData()
    {
      Console.WriteLine("Hello this is a very classified data.");
    }

  }
  class Secure
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter Password");
      var Pass = Console.ReadLine();
      if (Pass == "OpenApp")
      {
        typeof(Privateclass).GetMethod("MyData", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Privateclass(), null);
      }
    }
  }
}