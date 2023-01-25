using System;
using System.Collections.Generic;
using System.Linq;


namespace try_generic
{
  class program
  {
    private static void Main(string[] args)
    {
      charachters();
      numbers();
    }
    public static void charachters()
    {
      bool equal = calculator<string>.IsEqual("B", "M");

      if (equal)
      {
        Console.WriteLine("Equal");
      }
      else
      {
        Console.WriteLine("Not Equal");
      }

    }
    public static void numbers()
    {
      bool equal = calculator<int>.IsEqual(10, 10);
      if (equal)
      {
        Console.WriteLine("Equal");
      }
      else
      {
        Console.WriteLine("Not Equal");
      }

    }
  }
  class calculator<T>
  {
    public static bool IsEqual(T value1, T value2)
    {
      return value1.Equals(value2);
    }
  }
}