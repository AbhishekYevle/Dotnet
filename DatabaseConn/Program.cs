using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerSample
{
  class Program
  {
    static string cs = @"URI=file:C:/Users/yevlea/Practicals/DatabaseConn/Data/test.db";

    static void Main(string[] args)
    {
      // string cs = "Data Source=:C:/Users/yevlea/Practicals/DatabaseConn/Data/student.db:";
      Console.WriteLine("Start Application?");
      string ans = Console.ReadLine();
      while (ans == "start")
      {


        using var con = new SQLiteConnection(cs);
        con.Open();

        using var cmd = new SQLiteCommand(con);



        cmd.CommandText = "CREATE TABLE IF NOT EXISTS sample( id INTEGER, name TEXT, age INTEGER);";
        cmd.ExecuteNonQuery();
        Console.WriteLine("Connection Established");

        Console.WriteLine("Enter Command ");
        string user_command = Console.ReadLine();

        if (user_command == "show table")
        {
          cmd.CommandText = "SELECT * FROM sample;";
          cmd.ExecuteNonQuery();

          using SQLiteDataReader reader = cmd.ExecuteReader();
          Console.WriteLine($"{reader.GetName(0),-3} {reader.GetName(1),-8} {reader.GetName(2),8}");
          while (reader.Read())
          {
            Console.WriteLine($"{reader.GetInt32(0),-3} {reader.GetString(1),-8} {reader.GetInt32(2),8}");
          }
        }


        else if (user_command == "add data")
        {
          Console.WriteLine("How many rows?");
          int row = Convert.ToInt32(Console.ReadLine());
          for (int i = 0; i <= row; i++)
          {
            Console.WriteLine("Enter Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            cmd.CommandText = $"INSERT INTO sample(id, name, age) values({id}, '{name}',{age});";
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
          }

        }



        else if (user_command == "update data")
        {
          Console.WriteLine("Update Name:");
          string up_name = Console.ReadLine();
          Console.WriteLine("Name to be replaced");
          string rp_name = Console.ReadLine();

          cmd.CommandText = "UPDATE  sample SET name='" + up_name + "' WHERE name='" + rp_name + "';";
          cmd.ExecuteNonQuery();
          Console.WriteLine("Data Updated");
        }
        if (user_command == "exit")
        {
          return;
        }
      }









    }
  }
}