﻿using DF.ShoppingList.DataModel.Contracts;

namespace DataModel.SQLiteX
{
  public class ShoppingItem : IShoppingItem
  {
    #region Implementation of IShoppingItem

    public string ItemName { get; set; }

    #endregion
  }
}