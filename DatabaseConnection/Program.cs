using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userData
{
  class userinfo
  {

    public static void Main(string[] args)
    {
      Console.WriteLine("Start program?");
      string i = Console.ReadLine();

      while (i == "start")
      {

        Console.WriteLine("Enter Command:");
        string userCommand = Console.ReadLine();
        if (userCommand == "create table")
        {
          Database.createTable();
          Console.WriteLine("Table Created successfully.");
        }
        else if (userCommand == "add data")
        {
          Database.AddTable();
          Console.WriteLine("Data Added successfully.");
        }
        else if (userCommand == "show table")
        {
          Database.showTable();

        }
        else if (userCommand == "update table")
        {
          Database.updateTable();
        }
        // else if
        if (userCommand == "exit")
        {
          break;
        }
      }
    }
  }

  class Database
  {
    public static string dbpath = @"URI=file:C:/Users/yevlea/MyPrograms/DatabaseConnection/database/userdata.db";
    // create table
    public static void createTable()
    {
      using var sqlcon = new SQLiteConnection(Database.dbpath);
      using var cmd = new SQLiteCommand(sqlcon);
      sqlcon.Open();

      Console.WriteLine("Enter Table Name:");
      var tableName = Console.ReadLine();

      Console.WriteLine("id is first column in default.");

      Console.WriteLine("Second Column name:");
      var SecCol = Console.ReadLine();
      Console.WriteLine("Second Column type:");
      var SecColtype = Console.ReadLine();


      Console.WriteLine("Third column name:");
      var thirdCol = Console.ReadLine();
      Console.WriteLine("Third column type:");
      var thirdColtype = Console.ReadLine();


      cmd.CommandText = $"CREATE TABLE IF NOT EXISTS {tableName}(id INTEGER AUTO INREMENT, {SecCol} {SecColtype}, {thirdCol} {thirdColtype});";
      cmd.ExecuteNonQuery();
    }

    //Add adta in table 
    public static void AddTable()
    {
      using var sqlcon = new SQLiteConnection(Database.dbpath);
      using var cmd = new SQLiteCommand(sqlcon);
      sqlcon.Open();

      Console.WriteLine("Enter Table name :");
      var tableName = Console.ReadLine();

      Console.WriteLine("Enter ID:");
      int id = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter Name:");
      var name = Console.ReadLine();

      Console.WriteLine("Enter Nickname:");
      var age = Console.ReadLine();

      cmd.CommandText = $"INSERT INTO {tableName}(id, name, age) VALUES({id}, '{name}', '{age}');";
      cmd.ExecuteNonQuery();

    }
    public static void showTable()
    {
      using var sqlcon = new SQLiteConnection(Database.dbpath);
      using var cmd = new SQLiteCommand(sqlcon);
      sqlcon.Open();

      Console.WriteLine("Enter Table name :");
      var tableName = Console.ReadLine();

      cmd.CommandText = $"SELECT * FROM {tableName};";
      cmd.ExecuteNonQuery();

      using SQLiteDataReader reader = cmd.ExecuteReader();

      Console.WriteLine($"{reader.GetName(0),-5} {reader.GetName(1),-10} {reader.GetName(2),5}");
      while (reader.Read())
      {
        Console.WriteLine($"{reader.GetInt32(0),-5} {reader.GetString(1),-10} {reader.GetString(2),5}");
      }

    }
    public static void updateTable()
    {
      using var sqlcon = new SQLiteConnection(Database.dbpath);
      using var cmd = new SQLiteCommand(sqlcon);
      sqlcon.Open();

      Console.WriteLine("Enter Table name :");
      var tableName = Console.ReadLine();

      Console.WriteLine("Update Name:");
      var up_name = Console.ReadLine();

      Console.WriteLine("Name to be replaced");
      var rp_name = Console.ReadLine();

      cmd.CommandText = $"UPDATE {tableName} SET name='{up_name}' WHERE name='{rp_name}';";
      cmd.ExecuteNonQuery();
      Console.WriteLine("Data Updated");
    }

  }
}