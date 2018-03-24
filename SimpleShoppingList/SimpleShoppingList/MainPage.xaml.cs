using System;
using System.Collections.Generic;
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
      Dictionary<Type, Page> viewModelMapping = new Dictionary<Type, Page>()
      {
        {typeof(ShoppingListAppMainVM), new StartPageView() },
        {typeof(ShoppingListVM.ShoppingListVM), new ShoppingListView()}
      };
      navigationService.Init(Navigation, viewModelMapping);

      BindingContext = new ShoppingListAppMainVM(navigationService);
    }
  }
}