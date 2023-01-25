using System.Diagnostics;
using System.Text;
class Structure
{
  struct employee
  {
    public int EmpId;
    public string EmpName;
    public bool Attendance;

  }

  public static void Main(string[] args)
  {
    employee emp1;
    employee emp2;
    employee emp3;

    emp1.EmpId = 1;
    emp2.EmpId = 2;
    emp3.EmpId = 3;

    emp1.EmpName = "John";
    emp2.EmpName = "Trumph";
    emp3.EmpName = "Giniee";

    emp1.Attendance = true;
    emp2.Attendance = true;
    emp3.Attendance = true;

    // Console.WriteLine("All the details of Employees.");

    // Console.WriteLine("Employee id is {0}", emp1.EmpId);
    // Console.WriteLine("Employee Name is {0}", emp1.EmpName);
    // Console.WriteLine("Employee is present! {0}", emp1.Attendance);

    // Console.WriteLine("Employee id is {0}", emp2.EmpId);
    // Console.WriteLine("Employee Name is {0}", emp2.EmpName);
    // Console.WriteLine("Employee is present! {0}", emp2.Attendance);

    // Console.WriteLine("Employee id is {0}", emp3.EmpId);
    // Console.WriteLine("Employee Name is {0}", emp3.EmpName);
    // Console.WriteLine("Employee is present! {0}", emp3.Attendance);

    // Console.WriteLine("");

    // ToStringTable Class is in another file

    IEnumerable<Tuple<int, String, bool>> employees = new[]
    {
      Tuple.Create(emp1.EmpId, emp1.EmpName, emp1.Attendance),
      Tuple.Create(emp2.EmpId, emp2.EmpName, emp2.Attendance),
      Tuple.Create(emp3.EmpId, emp3.EmpName, emp3.Attendance),
    };

    Console.WriteLine(employees.ToStringTable(
      new[] { "Emp ID", "Emp Name", "Attendance" },
      a => a.Item1, a => a.Item2, a => a.Item3));


  }

  // (employee)String.Format("|{0,5}|{1,5}|{2,5}|", emp1.EmpId, emp2.EmpName, emp3.Attendance);

}
