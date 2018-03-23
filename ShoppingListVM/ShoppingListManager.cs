using System.Collections.ObjectModel;
using System.Linq;
using DF.ShoppingList.DataModel.Contracts;

namespace ShoppingListVM
{
  public class ShoppingListManager
  {
    private readonly IShoppingListDB _dataBase;

    public ShoppingListManager(IShoppingListDB dataBase)
    {
      _dataBase = dataBase;

      initLists();
    }

    private void initLists()
    {
      _dataBase.Load();
      ShoppingLists = new ObservableCollection<ShoppingListVM>(_dataBase.ShoppingLists.Select(dbList => new ShoppingListVM(dbList)));
    }

    public ObservableCollection<ShoppingListVM> ShoppingLists { get; set; }
  }
}
