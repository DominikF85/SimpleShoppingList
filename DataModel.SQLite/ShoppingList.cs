using System;
using System.Collections.Generic;
using DF.ShoppingList.DataModel.Contracts;
using SQLite;

namespace DataModel.SQLiteX
{
  public class ShoppingList : IShoppingList
  {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    private List<ShoppingItem> SQliteStorageItems { get; set; }

    #region Implementation of IShoppingList

    public string Name { get; set; }

    public DateTime ScheduledDate { get; set; }

    [Ignore]
    public ICollection<IShoppingItem> Items { get; }

    #endregion
  }
}