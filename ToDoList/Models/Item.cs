using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    // private int _id;

    public Item (string description)
    {
      _description = description;
      // _id = _instances.Count;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetId()
    {
      // Temporarily returning dummy id to get beyond compiler errors, until we refactor to work with database.
      return 0;
    }

    public static List<Item> GetAll()
    {
      Item dummyItem = new Item("dummy item");
      List<Item> allItems = new List<Item> { dummyItem };
      // MySqlConnection conn = DB.Connection();
      // conn.Open();
      // MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      // cmd.CommandText = @"SELECT * FROM items;";
      // MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      // while(rdr.Read())
      // {
      //   int itemId = rdr.GetInt32(0);
      //   string itemDescription = rdr.GetString(1);
      //   Item newItem = new Item(itemDescription, itemId);
      //   allItems.Add(newItem);
      // }
      // conn.Close();
      // if (conn != null)
      // {
      //   conn.Dispose();
      // }
      return allItems;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM items;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
       conn.Dispose();
      }
    }

    public static Item Find(int searchId)
    {
      // Temporarily returning dummy item to get beyond compiler errors, until we refactor to work with database.
      Item dummyItem = new Item("dummy item");
      return dummyItem;
    }

  }
}
