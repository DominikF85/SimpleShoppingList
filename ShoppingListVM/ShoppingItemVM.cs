using System;
using System.Collections.Generic;
using System.Text;
using DF.ShoppingList.DataModel.Contracts;
using KEB.Utilities.NotifyPropertyChanged;

namespace ShoppingListVM
{
  public class ShoppingItemVM : NPCBase
  {
    private readonly IShoppingItem _model;

    public ShoppingItemVM(IShoppingItem model)
    {
      _model = model;
    }

    public string Name
    {
      get { return _model.ItemName; }
      set
      {
        _model.ItemName = value;
        NotifyChanged();
      }
    }
  }
}
