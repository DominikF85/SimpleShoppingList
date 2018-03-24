using DataModel.SQLite;
using DF.XamarinFormsNavigationService.Contracts;
using KEB.Utilities.NotifyPropertyChanged;

namespace ShoppingListVM
{
  public class ShoppingListAppMainVM : NPCBase
  {
    private ShoppingListVM _selectedList;

    public ShoppingListAppMainVM(INavigationService navigationService)
    {
      NavigationService = navigationService;
      var db = new ShoppingListDB();
      ShoppingListManager = new ShoppingListManager(db);
    }

    public string AppTitle { get; } = "Einkaufszettel-App!";

    public ShoppingListManager ShoppingListManager { get; }

    public ShoppingListVM SelectedList
    {
      get { return _selectedList; }
      set { SetProperty(ref _selectedList, value); }
    }
    public INavigationService NavigationService { get; }
  }
}