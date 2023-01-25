using System;
using System.Linq;
using System.Linq.Expressions;

namespace LinQ
{
  class program
  {
    public static void Main(string[] args)
    {
      string[] countries = { "India", "UK", "USA", "Canada", "Africa" };
      IList<int> Numbers = new List<int> { 10, 56, 25, 78, 100, 45, 68, 91, 23, 37, 87 };
      IList<int> Numbers01 = new List<int> { 10, 56, 25, 78, 105, 45, 69, 91, 23, 37, 88 };
      IList<string> EmptyList = new List<string>();

      // IEqualityComaparer
      Console.WriteLine("<=====IEqualityComparer=====>");
      IList<Student> studentList1 = new List<Student>() {
      new Student() { StudentID = 1, StudentName = "John" },
      new Student() { StudentID = 2, StudentName = "Steve" },
      new Student() { StudentID = 3, StudentName = "Bill" },
      new Student() { StudentID = 4, StudentName = "Ram"  },
      new Student() { StudentID = 5, StudentName = "Ron" }
    };

      IList<Student> studentList2 = new List<Student>() {
      new Student() { StudentID = 1, StudentName = "John" },
      new Student() { StudentID = 2, StudentName = "Steve" },
      new Student() { StudentID = 3, StudentName = "Bill" },
      new Student() { StudentID = 4, StudentName = "Ram" },
      new Student() { StudentID = 5, StudentName = "Ron" }
    };

      bool isEqual = studentList1.SequenceEqual(studentList2, new StudentComparer());

      Console.WriteLine(isEqual);

      // Invoke Expression 
      Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

      //compile Expression using Compile method to invoke it as Delegate
      Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

      //Invoke
      bool result01 = isTeenAger(new Student() { StudentID = 1, StudentName = "Steve", Age = 20 });

      Console.WriteLine(result01);

      // Concat()
      var concat = Numbers.Concat(Numbers01);
      Console.WriteLine("<=====Concat=====>");
      foreach (string ex in countries)
      {
        Console.WriteLine(ex);

      }

      // distinct()
      Console.WriteLine("<=====Distinct=====>");
      var DistinctList = Numbers.Distinct();

      Console.Write("(");
      foreach (var item in DistinctList)
      {
        Console.Write(item + ",");
      }
      Console.WriteLine(")");

      // except()
      Console.WriteLine("<=====Except=====>");
      var ExceptList = Numbers.Except(Numbers01);
      Console.Write("(");
      foreach (var item in ExceptList)
      {
        Console.Write(item + ",");
      }
      Console.WriteLine(")");

      // intersect()
      Console.WriteLine("<=====Intersect=====>");
      var IntersectList = Numbers.Intersect(Numbers01);
      Console.Write("(");
      foreach (var item in IntersectList)
      {
        Console.Write(item + ",");
      }
      Console.WriteLine(")");

      // Union
      Console.WriteLine("<=====Union=====>");
      var UnionList = Numbers.Union(Numbers01);
      Console.Write("(");
      foreach (var item in UnionList)
      {
        Console.Write(item + ",");
      }
      Console.WriteLine(")");

      // skip()
      Console.WriteLine("<=====Skip & SkipWhile=====>");
      var SkipElement = countries.Skip(3);
      Console.Write("(");
      foreach (var item in SkipElement)
      {
        Console.Write(item + ",");
      }
      Console.WriteLine(")");

      var SkipWhileList = countries.SkipWhile(x => x.Length <= 5);
      Console.Write("(");
      foreach (var item in SkipWhileList)
      {
        Console.Write(item + ",");
      }
      Console.WriteLine(")");

      // Take()
      Console.WriteLine("<=====Take & TakeWhile=====>");
      var TakeList = countries.Take(3);
      Console.Write("(");
      foreach (var item in TakeList)
      {
        Console.Write(item + ",");
      }
      Console.WriteLine(")");

      var takeWhileList = countries.TakeWhile(x => x.Length > 4);
      Console.Write("(");
      foreach (var item in takeWhileList)
      {
        Console.Write(item);
      }
      Console.WriteLine(")");




      // DefaultIfEmpty()
      Console.WriteLine("<=====DefaultIfEmpty=====>");
      var newList01 = EmptyList.DefaultIfEmpty("Empty List");
      Console.WriteLine("Value : {0}", newList01.ElementAt(0));

      //   Empty() & GetType()
      Console.WriteLine("<=====Empty & GetType=====>");
      string result = string.Empty;
      Console.WriteLine("Type of List {0}", Numbers.Count());

      // ElememntAt()
      Console.WriteLine("<=====ElementAt=====>");
      var position = countries.ElementAt(4);
      Console.WriteLine(position);

      // First & FirstOrDefault
      Console.WriteLine("<=====First & FirstOrDefault=====>");
      Console.WriteLine("Larger than 50 : {0}", Numbers.First(x => x > 50));
      Console.WriteLine("Larger than 50 : {0}", countries.FirstOrDefault(x => x.Contains("A")));

      // Last & LastOrDefault
      Console.WriteLine("<=====Last & LastOrDefault=====>");
      Console.WriteLine("Larger than 50 : {0}", Numbers.Last(x => x > 50));
      Console.WriteLine("Larger than 50 : {0}", countries.LastOrDefault(x => x.Contains("A")));

      // SequenceEqual()
      Console.WriteLine("<=====SequenceEqual=====>");
      bool compare = Numbers.SequenceEqual(Numbers01);
      Console.WriteLine(compare);




    }
  }

  public class Student
  {

    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
  }

  class StudentComparer : IEqualityComparer<Student>
  {
    public bool Equals(Student x, Student y)
    {
      if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
        return true;

      return false;
    }

    public int GetHashCode(Student obj)
    {
      return obj.GetHashCode();
    }
  }
}




// int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//       // var Total = Numbers.Where(x => x % 2 == 0 || x % 2 !=).Max();
//       // var Total = Numbers.Where(x => x % 2 == 0).Min();
//       // var Total = Numbers.Average();
//       // var Total = Numbers.Sum();
//       var Total = Numbers.Count();
//       Console.WriteLine(Total);