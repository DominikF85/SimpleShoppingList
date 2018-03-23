using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DF.ShoppingList.DataModel.Contracts;
using SQLite;

namespace DataModel.SQLite
{
  public class ShoppingListDB : IShoppingListDB
  {
    public static readonly string SQLiteDBPath =
      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SimpleShoppingList", "data.sqlite");

    private SQLiteConnection _db;

    public ShoppingListDB()
    { }


    #region Implementation of IShoppingListDB

    public void Load()
    {
      var dir = new FileInfo(SQLiteDBPath).Directory;
      if (!dir.Exists)
      {
        dir.Create();
      }





      _db = new SQLiteConnection(SQLiteDBPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);

      _db.CreateTable<ShoppingList>();

      //TEST-CONTENT
      //-----------------------------------------------
      if (!_db.Table<ShoppingList>().Any())
      {
        _db.Insert(new ShoppingList()
        {
          Id = 0,
          Items = new List<IShoppingItem>(),
          Name = "ALDI",
          ScheduledDate = DateTime.Today.AddDays(1)
        });

        _db.Insert(new ShoppingList()
        {
          Id = 1,
          Items = new List<IShoppingItem>(),
          Name = "REWE",
          ScheduledDate = DateTime.Today.AddDays(1)
        });

        _db.Insert(new ShoppingList()
        {
          Id = 1,
          Items = new List<IShoppingItem>(),
          Name = "Rossmann",
          ScheduledDate = DateTime.Today.AddDays(1)
        });
      }
      //-----------------------------------------------

      ShoppingLists = _db.Table<ShoppingList>().ToList().AsQueryable();
    }

    public IQueryable<IShoppingList> ShoppingLists { get; private set; }

    public void Save()
    {
    }

    #endregion
  }
}
