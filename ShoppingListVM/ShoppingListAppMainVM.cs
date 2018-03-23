using DataModel.SQLite;
using KEB.Utilities.NotifyPropertyChanged;

namespace ShoppingListVM
{
  public class ShoppingListAppMainVM : NPCBase
  {
    public ShoppingListAppMainVM()
    {
      var db = new ShoppingListDB();
      ShoppingListManager = new ShoppingListManager(db);
    }

    public string AppTitle { get; } = "ShoppingListApp";

    public ShoppingListManager ShoppingListManager { get; }
  }
}
