using Userlibrary;
using AccLib;

namespace MainProgram
{
  public class Main1
  {
    public static void Main(string[] args)
    {
      // // User Class || Coupling
      // User user = new User(name: "Abhishek", age: 30);
      // user.sayHello();

      // // TaxCalculator Class || Interfaces
      // TaxCalculator calculator = getCalculator();
      // calculator.CalculateTax();

      // // Account class || AccLib Library || Encapsulation
      // var account = new Account();

      // // Credit amount in account
      // Console.Write("Enter amount to be Credited :");
      // float addAmount = float.Parse(Console.ReadLine());
      // account.deposite(amount: addAmount);

      // // Debit amount from account 
      // Console.Write("Enter amount to be Debited :");
      // float rmAmount = float.Parse(Console.ReadLine());
      // account.withdraw(amount: rmAmount);

      // // show Balance 
      // Console.Write("Current Balance of Account :");

      // Console.WriteLine(account.getBalance());


      // // Mail Services || Abstract Method
      // var mailService = new MailService();
      // mailService.sendMail();

      // UIControl Class || Inheritance Method || Polymorphism Method
      var textBox = new TextBox();
      textBox.enable();

      drawUIControl(new CheckBox());
      drawUIControl(new TextBox());





    }

    public static TaxCalculator getCalculator()
    {
      return new TaxCalculator2021();

    }

    // Polymorphism Method
    public static void drawUIControl(UIControl control)
    {
      control.draw();
    }
  }
}