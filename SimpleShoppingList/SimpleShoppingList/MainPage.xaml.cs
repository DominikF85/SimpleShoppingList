using DF.XamarinFormsNavigationService;
using DF.XamarinFormsNavigationService.Contracts;
using ShoppingListVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DF.ShoppingList
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class MainPage : MasterDetailPage
  {
    public MainPage()
    {
      InitializeComponent();

      INavigationService navigationService = new NavigationService();

      navigationService.Init(DetailNavigationPage.Navigation, () => { this.IsPresented = false; });

      navigationService.RegisterMapping(typeof(ShoppingListAppMainVM), new StartPageView());
      navigationService.RegisterMapping(typeof(ShoppingListVM.ShoppingListVM), new ShoppingListView());
      navigationService.RegisterMapping(typeof(CreateNewShoppingListPageVM), new CreateNewShoppingListPage());

      BindingContext = new ShoppingListAppMainVM(navigationService);
    }
  }
}