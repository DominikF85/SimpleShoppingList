using DataModel.SQLite;
using KEB.Utilities.NotifyPropertyChanged;

namespace ShoppingListVM
{
  public class ShoppingListAppMainVM : NPCBase
  {
    private ShoppingListVM _selectedList;

    public ShoppingListAppMainVM()
    {
      var db = new ShoppingListDB();
      ShoppingListManager = new ShoppingListManager(db);
    }

    public string AppTitle { get; } = "ShoppingListApp";

    public ShoppingListManager ShoppingListManager { get; }

    public ShoppingListVM SelectedList
    {
      get { return _selectedList; }
      set { SetProperty(ref _selectedList, value); }
    }
  }
}
