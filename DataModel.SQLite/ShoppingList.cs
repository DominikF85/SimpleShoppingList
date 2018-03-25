using System;
using System.Collections.Generic;
using System.Linq;
using DF.ShoppingList.DataModel.Contracts;
using SQLite;

namespace DataModel.SQLite
{
  public class ShoppingList : IShoppingList
  {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    private List<ShoppingItem> SQliteStorageItems
    {
      get { return Items.OfType<ShoppingItem>().ToList(); }
      set { Items = new List<IShoppingItem>(value); }
    }

    #region Implementation of IShoppingList

    public string Name { get; set; }

    public DateTime ScheduledDate { get; set; }

    [Ignore]
    public ICollection<IShoppingItem> Items { get; set; } = new List<IShoppingItem>();

    public IShoppingItem CreateNewItem()
    {
      return new ShoppingItem() { ItemName = "???" };
    }

    #endregion
  }
}