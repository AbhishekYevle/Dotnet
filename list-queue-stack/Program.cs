using System;
using System.Linq;
using System.Collections.Generic;

namespace Generic
{



  class Generic1
  {

    static void Main(String[] args)
    {

      List<int> listObj = new List<int>();

      listObj.Add(1);
      listObj.Add(10);
      listObj.Add(3);



      Console.WriteLine("list second Value : {0}", listObj.ElementAt(1));



      Dictionary<int, string> objDic = new Dictionary<int, string>();

      objDic.Add(12, "Hey");
      Console.WriteLine("Dictionary Value : {0}", objDic.ElementAt(0));
      Stack<int> stc = new Stack<int>();

      stc.Push(1);

      stc.Push(2);

      stc.Push(3);



      Console.WriteLine("Stack value : {0}", stc.Pop());



      Queue<int> objQueue = new Queue<int>();

      objQueue.Enqueue(1);

      objQueue.Enqueue(2);

      objQueue.Enqueue(3);

      objQueue.Enqueue(4);



      Console.WriteLine("Queue value : {0}", objQueue.Dequeue());



      Employee Empobj1 = new Employee();

      Empobj1.ID = 101;

      Empobj1.Name = "riya";

      Empobj1.Address = "vadodara";



      Employee Empobj2 = new Employee();

      Empobj2.ID = 102;

      Empobj2.Name = "Diya";

      Empobj2.Address = "Surat";

      List<Employee> Emplistobj = new List<Employee>();

      Emplistobj.Add(Empobj1);

      Emplistobj.Add(Empobj2);

      foreach (Employee emp in Emplistobj)

      {

        Console.WriteLine(emp.ID);

        Console.WriteLine(emp.Name);

        Console.WriteLine(emp.Address);



        Console.WriteLine();



      }

    }







    public class Employee
    {

      public int ID;

      public string Name;

      public string Address;



    }

  }

}




