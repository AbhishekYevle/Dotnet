namespace trial001
{
  class mainFile
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Console Application.");

      for (int y = 1; y <= 5; y++)
      {
        for (int x = 0; x <= y; x++)
        {
          Console.Write("*");

        }
        Console.WriteLine();
      }

    }


  }
}