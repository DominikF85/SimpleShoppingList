using System;
using System.IO;
using System.Linq;
using DF.ShoppingList.DataModel.Contracts;
using SQLite;

namespace DataModel.SQLiteX
{
  public class ShoppingListDB : IShoppingListDB
  {
    public static readonly string SQLiteDBPath =
      Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "SimpleShoppingList", "data.sqlite");

    private SQLiteConnection _db;

    public ShoppingListDB()
    { }


    #region Implementation of IShoppingListDB

    public void Load()
    {
      _db = new SQLiteConnection(SQLiteDBPath, SQLiteOpenFlags.Create);
      _db.CreateTable<ShoppingList>();

      ShoppingLists = _db.Table<ShoppingList>().ToList().AsQueryable();
    }

    public IQueryable<IShoppingList> ShoppingLists { get; private set; }

    public void Save()
    {
    }

    #endregion
  }
}
