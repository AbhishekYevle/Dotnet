using System;
using System.Threading;

namespace threads
{
  class ThreadTest
  {
    static void Main()
    {
      Thread t = new Thread(new ThreadStart(First));

      t.Start();   // Run Go() on the new thread.
      Go();        // Simultaneously run Go() in the main thread.
    }
    static void First()
    {
      Console.WriteLine("Hello1");
    }
    static void Go()
    {
      Console.WriteLine("hello!");
    }
  }
}