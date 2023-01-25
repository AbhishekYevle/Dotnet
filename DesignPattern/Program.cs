using System;
using library;

namespace MainProgram
{
  public class Main1
  {
    public static void Main(string[] args)
    {
      User user = new User(name: "Abhishek", age: 30);
      user.sayHello();
    }
  }
}