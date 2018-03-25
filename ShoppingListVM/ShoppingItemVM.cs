using System.Windows.Input;
using DF.ShoppingList.DataModel.Contracts;
using KEB.Utilities.NotifyPropertyChanged;
using Xamarin.Forms;

namespace ShoppingListVM
{
  public class ShoppingItemVM : NPCBase
  {
    private readonly IShoppingItem _model;

    public ShoppingItemVM(IShoppingItem model)
    {
      _model = model;

      TogglePurchasedCommand = new Command(() => togglePurchased());
    }

    private void togglePurchased()
    {
      IsPurchased = !IsPurchased;
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

    public bool IsPurchased
    {
      get { return _model.IsPurchased; }
      set
      {
        _model.IsPurchased = value;
        NotifyChanged();
      }
    }

    public ICommand TogglePurchasedCommand { get; }

  }
}
