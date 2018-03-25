
using System;
using ShoppingListVM;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DF.ShoppingList
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class MainPageMaster : ContentPage
  {
    public MainPageMaster()
    {
      InitializeComponent();
    }

    private void ShoppingListsListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
      //TODO: Remove this from the Code-Behing! (e.g. by using a Behaviour!)

      ((ShoppingListAppMainVM)BindingContext).NavigationService.NavigateTo(typeof(ShoppingListVM.ShoppingListVM), false);
    }
  }
}