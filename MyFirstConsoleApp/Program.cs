namespace myConsoleApp
{

  class program
  {
    static void Main(string[] args)
    {
      // string path = @"C:\Users\yevlea\Downloads\test.txt";

      args = new string[22];
      args[0] = "Welcome";
      args[1] = "Method";
      args[2] = "Output";
      args[3] = "Datatype";
      args[4] = "Typecasting";
      args[5] = "UserInput";
      args[6] = "Operators";
      args[7] = "Math";
      args[8] = "Class";
      args[9] = "Object";
      args[10] = "Constructor";
      args[11] = "Encapsulation";
      args[12] = "Inheritance";
      args[13] = "Polymorphism";
      args[14] = "Abstract";
      args[15] = "Interfaces";
      args[16] = "Enum";
      args[17] = "File Write";
      args[18] = "File Read";
      args[19] = "Exception";
      args[20] = "Checkage";
      args[21] = "Program Library";

      Console.WriteLine("Start Application");
      var ask = Console.ReadLine();


      while (ask != null && ask == "start")
      {

        Console.WriteLine("Enter Command");
        var cmd_ln = Console.ReadLine();


        foreach (string arg in args)
        {


          if (cmd_ln == arg && cmd_ln != "exit")

          {




            switch (arg)
            {
              case "Method":
                // Method parameter 
                // args[1]

                Console.WriteLine("Write your name?");
                var tmp_nam = Console.ReadLine();
                Console.WriteLine("Write hours?");
                int tmp_val = Convert.ToInt32(Console.ReadLine());

                if (tmp_nam != null)
                {

                  hello(tmp_nam, tmp_val);


                }
                int num1 = plusMethod(8, 5);
                double num2 = plusMethod(4.3, 10.2);
                Console.WriteLine(num1);
                Console.WriteLine(num2);

                break;



              // Output Section - print simple statements 
              // args[2]
              case "Output":
                output.prac2.second();
                break;

              // Datatype Section - unique data type
              // args[3]
              case "Datatype":
                datatype.prac3.datatype();
                break;

              //Typecasting - Conversion of type of variable
              // args[4]
              case "Typecasting":
                typecasting.prac4.typecasting();
                break;
            }
          }
          if (cmd_ln == "exit")
          {
            return;
          }

        }
      }
    }
    public static void hello(string h, int m)
    {
      Console.WriteLine(h + " is Coding.....  " + m);
    }

    // method overloading
    public static int plusMethod(int x, int y)
    {
      return x + y;
    }

    // method overloading - multiple methods have same name as lomg as the type of parameter or numbers are diffrent 
    public static double plusMethod(double x, double y)
    {
      return x + y;
    }

  }
}

