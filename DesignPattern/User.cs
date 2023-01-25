namespace library
{
  class User
  {
    // Fields
    public string name;
    public User(string name, int age)
    {
      this.name = name;
    }


    // Methods
    public void sayHello()
    {
      Console.WriteLine("Hi, My name is " + name);
    }

  }
}