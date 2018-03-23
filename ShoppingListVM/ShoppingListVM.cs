using System;
using System.Collections.Generic;
using System.Text;
using DF.ShoppingList.DataModel.Contracts;
using KEB.Utilities.NotifyPropertyChanged;

namespace ShoppingListVM
{
    public class ShoppingListVM: NPCBase
    {
      private readonly IShoppingList _model;

      public ShoppingListVM(IShoppingList model)
      {
        _model = model;
      }

      public string Name
      {
        get { return _model.Name;}
        set
        {
          _model.Name = value;
          NotifyChanged();
        }
      }
    }
}
