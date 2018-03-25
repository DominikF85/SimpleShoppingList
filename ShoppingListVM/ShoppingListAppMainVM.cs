using System.Windows.Input;
using DataModel.SQLite;
using DF.XamarinFormsNavigationService.Contracts;
using KEB.Utilities.NotifyPropertyChanged;
using Xamarin.Forms;

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

      CreateNewShoppingListCommand =
        new Command(() => NavigationService.NavigateTo(typeof(CreateNewShoppingListPageVM), false));
    }

    public string AppTitle { get; } = "Einkaufszettel-App!";

    public ShoppingListManager ShoppingListManager { get; }

    public ShoppingListVM SelectedList
    {
      get { return _selectedList; }
      set { SetProperty(ref _selectedList, value); }
    }

    public CreateNewShoppingListPageVM CreateNewShoppingListPageVM { get; }

    public INavigationService NavigationService { get; }

    #region Commands

    public ICommand CreateNewShoppingListCommand { get; }

    #endregion
  }
}