namespace myConsoleApp
{
  class program
  {
    static void Main(string[] args)
    {

      // if (args.Equals("exit", StringComparison.OrdinalIgnoreCase))
      string path = @"C:\Users\yevlea\Downloads\test.txt";

      args = new string[22];
      args[0] = "Welcome";
      args[1] = "Method parameter & overloading";
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
      // args[22] = null;

      Console.WriteLine("Enter Command");
      string Command_line = Console.ReadLine();


      foreach (string arg in args)
      {


        if (Command_line == arg)
        {


          switch (arg)
          {
            case "method parameter & overloading":
              // Method parameter 
              // args[1]
              Console.WriteLine("Write your name?");
              string Temp_name = Console.ReadLine();
              Console.WriteLine("Write hours?");
              int Temp_value = int.Parse(Console.ReadLine());
              hello(Temp_name, Temp_value);

              //mwthod overloading
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

            // Typecasting - Conversion of type of variable
            // args[4]
            case "Typecasting":
              typecasting.prac4.typecasting();
              break;

            // userInput - user gives values
            // args[5]
            case "UserInput":
              userInput.prac5.userInput();
              break;

            // Operators - unique operations performed by operators
            // args[6]
            case "Operators":
              operators.prac6.operators();
              break;

            // Math - used for max min sqrt values
            // args[7]
            case "Math":
              mathematics.prac7.mathematics();
              break;

            // class - exachange data from different classes
            // args[8]
            case "Class":
              classes.prac8.classes();
              break;

            //object creating
            // args[9]
            case "Object":
              obj.bike.obj();
              break;

            //Constructor
            // args[10]
            case "Constructor":
              car audi = new car();
              Console.WriteLine(audi.color);
              break;

            //Encapsulation
            // args[11]
            case "Encapsulation":
              engi obje = new engi();
              Console.WriteLine("Enter Your Name?");
              obje.streamName = Console.ReadLine();
              Console.WriteLine(obje.streamName);
              break;

            //inheritance
            // args[12]
            case "Inheritance":
              cars myCar = new cars();
              myCar.voice();
              Console.WriteLine(myCar.brand + " " + myCar.modelName);
              break;

            //polymorphism
            // args[13]
            case "Polymorphism":
              vehical myVehical = new vehical();
              vehical myCars = new cars();
              vehical myCars1 = new cars1();

              myCars1 = (vehical)myVehical;

              myVehical.voice();
              ((vehical)myCars).voice();
              ((vehical)myCars1).voice();

              myCars.voice();
              ((cars)myVehical).voice();
              ((cars)myCars1).voice();

              myCars1.voice();
              ((cars1)myVehical).voice();
              ((cars1)myCars).voice();
              break;

            //Abstarct method
            // args[14]
            case "Abstract":
              Obj.Square SQ = new Obj.Square();
              Obj.circle objecto = new Obj.circle();
              objecto.Sos();
              objecto.universal();
              ((Obj.circle)objecto).universal();
              ((Obj.circle)objecto).Sos();
              ((Obj.Square)SQ).universal();
              ((Obj.Square)SQ).Sos();
              // genetics.Americans newHuman = new genetics.Americans();
              // newHuman.Sos();
              // newHuman.humans()
              break;

            //Interfaces
            // args[15]
            case "Interfaces":
              interfaces.DemoClass myint = new interfaces.DemoClass();
              interfaces.DemoClass1 myint1 = new interfaces.DemoClass1();
              myint.myMethod();
              myint.myOtherMethod();

              myint1.myMethod();
              myint1.myOtherMethod();

              // ((interfaces.DemoClass)myint1).myMethod();
              // ((interfaces.DemoClass)myint1).myOtherMethod();

              // ((interfaces.DemoClass1)myint).myMethod();
              // ((interfaces.DemoClass1)myint).myOtherMethod();



              break;

            //enum - constatnt variables
            // args[16]
            case "Enum":
              int result = (int)rating.Excellent;
              Console.WriteLine(result);

              rating rslt = rating.Ver_Good;
              switch (rslt)
              {
                case rating.Very_Poor:
                  Console.Write("Your Performance is So Poor!!");
                  break;

                case rating.Good:
                  Console.Write("Your Performance is Good!!");
                  break;
                case rating.Ver_Good:
                  Console.Write("Your Performance is So Good!!");
                  break;
                case rating.Excellent:
                  Console.Write("Your Performance is Excellent!!");
                  break;


              }
              break;

            //write text in file operation
            // args[17]
            case "File Write":
              //variable is declared univarsal
              Console.WriteLine("Enter data in file:");
              string writetxt = Console.ReadLine() + Environment.NewLine;
              File.WriteAllText(path, writetxt);
              break;

            //Read Text from file operation
            // args[18]
            case "File Read":
              //variable is declared univarsal
              string readtxt = File.ReadAllText(path);
              Console.WriteLine(readtxt);
              break;

            //try catch method - exception
            // args[19]
            case "Exception":
              try
              {
                Console.WriteLine("Enter Number 1:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number 2:");
                int y = int.Parse(Console.ReadLine());

                int z = x / y;

                Console.WriteLine("The result is " + z + ".");

                // int[] num = { 1, 2, 3, 4, 5, 6 };
                // Console.WriteLine(num[8]);
              }
              catch (DivideByZeroException E_var)
              {
                Console.WriteLine(E_var.Message);
              }
              catch (FormatException E_var1)
              {
                Console.WriteLine("The input entered is not correct");
              }
              Console.WriteLine("<=======End of Program=======>");
              break;

            //exception methods
            // args[20]
            case "Checkage":
              int myAge = 0;
              Console.WriteLine("Enter Your Age?");
              myAge = Convert.ToInt32(Console.ReadLine());
              verify.checkAge(myAge);
              break;

            // program library
            // args[21]
            case "Program Library":
              program_lib.com();
              break;

            // args[22]
            // case null:
            //   Console.WriteLine("Closing Program......................");

            // break;

            // default program if any invalid input detected
            default:
              Console.WriteLine("<=======Invalid Input=======>");
              break;


          }
        }
        else if (Command_line.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
          Console.WriteLine("Closing Program......................");
          break;
        }
        // else
        // {
        //   Console.WriteLine("<=======Invalid Input=======>");
        //   break;
        // }
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

  class car
  {
    public string color;

    public car()
    {
      color = "Purple";
    }

  }
  // encapsulation
  class engi
  {
    private string Stream; //field
    public string streamName //property
    {
      get { return Stream; }
      set { Stream = value; }
    }
  }

  //inheritance - polymorphism
  class vehical //base class parent
  {
    public string brand = "toyota";
    public virtual void voice()
    {
      Console.WriteLine("frrrrrrrrr.......... frrrrrrrrrrrrrrr..............!!");
    }
  }

  class cars : vehical //derived class child
  {
    public string modelName = "Supra";
    public override void voice()
    {

      Console.WriteLine("Hmmmmmmmmmmmmm.............hmmmmmmmmmmmmmmm.........!");
    }
  }

  class cars1 : vehical //derived class child
  {
    public string modelName = "Fortuner";
    public override void voice()
    {
      Console.WriteLine("brrrrmmmmmmmmmmmmm.............brrrrrrmmmmmmmmmmmmmmm.........!");
    }
  }

  // Program Library - Which includes all the command args[22]
  class program_lib
  {
    public static void com()
    {
      Console.WriteLine("Welcome To MyFirstConsoleApplication");
      Console.WriteLine("1.method parameter & overloading");
      Console.WriteLine("2.output");
      Console.WriteLine("3.datatype");
      Console.WriteLine("4.typecasting");
      Console.WriteLine("5.userInput");
      Console.WriteLine("6.operators");
      Console.WriteLine("7.math");
      Console.WriteLine("8.class");
      Console.WriteLine("9.object");
      Console.WriteLine("10.constructor");
      Console.WriteLine("11.Encapsulation");
      Console.WriteLine("12.Inheritance");
      Console.WriteLine("13.Polymorphism");
      Console.WriteLine("14.Abstract");
      Console.WriteLine("15.Interfaces");
      Console.WriteLine("16.enum");
      Console.WriteLine("17.File Write");
      Console.WriteLine("18.File Read");
      Console.WriteLine("19.exception");
      Console.WriteLine("20.Checkage");
      Console.WriteLine("21.Exit");
      Console.WriteLine("22.Program Library");
    }
  }

}

//Interfaces 
namespace interfaces
{
  interface ifirstinterface
  {
    void myMethod();
  }

  interface isecondinterface
  {
    void myOtherMethod();
  }

  class DemoClass : ifirstinterface, isecondinterface
  {
    public void myMethod()
    {
      Console.WriteLine("This is first inetrface method.");
    }
    public void myOtherMethod()
    {
      Console.WriteLine("This is my second method.");
    }

  }
  class DemoClass1 : ifirstinterface, isecondinterface
  {
    public void myMethod()
    {
      Console.WriteLine("This is first duplicate inetrface method.");
    }
    public void myOtherMethod()
    {
      Console.WriteLine("This is my second duplicate method.");
    }
  }
}