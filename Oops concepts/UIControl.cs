// Inheritance Mehthod || Polymorphism Method

public abstract class UIControl
{
  public void enable()
  {
    System.Console.WriteLine("Enabled.");
  }

  public abstract void draw();
}

public class TextBox : UIControl
{
  public override void draw()
  {
    System.Console.WriteLine("Drwawing a textbox....");
  }

}

public class CheckBox : UIControl
{
  public override void draw()
  {
    System.Console.WriteLine("Drwawing a checkbox....");
  }
}