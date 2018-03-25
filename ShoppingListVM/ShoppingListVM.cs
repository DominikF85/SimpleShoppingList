using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using DF.ShoppingList.DataModel.Contracts;
using KEB.Utilities.NotifyPropertyChanged;
using Xamarin.Forms;

namespace ShoppingListVM
{
  public class ShoppingListVM : NPCBase
  {
    private readonly IShoppingList _model;

    public ShoppingListVM(IShoppingList model)
    {
      _model = model;
      AddItemCommand = new Command(() =>
      {
        IShoppingItem newItem = _model.CreateNewItem();
        _model.Items.Add(newItem);
        Items.Add(new ShoppingItemVM(newItem));
      });

      Items = new ObservableCollection<ShoppingItemVM>(model.Items.Select(modelItem => new ShoppingItemVM(modelItem)));
    }

    public string Name
    {
      get { return _model.Name; }
      set
      {
        _model.Name = value;
        NotifyChanged();
      }
    }

    public ICommand AddItemCommand { get; }

    public ObservableCollection<ShoppingItemVM> Items { get; }
  }
}
