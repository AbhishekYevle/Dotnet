using System;

namespace mainFile
{
  class loadPro
  {
    public static void Main(string[] args)
    {
      vehical FirstCar = new vehical();
      vehical SecCar = new cars();
      vehical thirdCar = new cars1();
      // SecCar = (vehical)FirstCar;

      ((vehical)thirdCar).voice();


      // FirstCar.voice();
      // SecCar.voice();
      // thirdCar.voice();



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
}