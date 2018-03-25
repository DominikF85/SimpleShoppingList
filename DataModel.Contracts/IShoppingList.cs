using System;
using System.Collections.Generic;

namespace DF.ShoppingList.DataModel.Contracts
{
  public interface IShoppingList
  {
    string Name { get; set; }

    DateTime ScheduledDate { get; set; }

    ICollection<IShoppingItem> Items { get; }

    IShoppingItem CreateNewItem();
  }
}